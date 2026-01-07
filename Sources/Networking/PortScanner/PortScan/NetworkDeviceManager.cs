using System.Diagnostics;

namespace PortScanner.PortScan;

using DeviceInfo = (string Ip, string Mac, string Manufacturer);

/// <summary>
/// Represents a class for collecting information about network devices within the same subnet by using ARP commands
/// and a service to retrieve manufacturer information based on MAC addresses.
/// </summary>
public class NetworkDeviceManager
{
    private readonly List<DeviceInfo> _devices = [];
    private readonly ManufacturerService _manufacturerService = new();
    private readonly ProcessStartInfo _arpStartInfo = new("arp", "-a")
    {
        RedirectStandardOutput = true,
        UseShellExecute = false,
        CreateNoWindow = true
    };

    /// <summary>
    /// Retrieves information about network devices within the same subnet by using ARP commands
    /// and a service to retrieve manufacturer information based on MAC addresses.
    /// </summary>
    /// <returns>A list of DeviceInfo tuples containing IP address, MAC address, and manufacturer information for each
    /// network device found in the local subnet.</returns>
    public async Task<List<DeviceInfo>> GetDevicesAsync()
    {
        string output = GetArpOutput();

        foreach (var line in output.Split('\n'))
        {
            if (!line.Contains("dynamic")) continue;

            var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length >= 2)
            {
                string ip = parts[0];
                string mac = parts[1];
                string manufacturer = await _manufacturerService.GetManufacturerByMacAsync(mac);
                _devices.Add((ip, mac, manufacturer));
            }
        }

        return _devices;
    }

    private string GetArpOutput()
    {
        using var process = Process.Start(_arpStartInfo);
        
        if (process == null)
            return string.Empty;

        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        return output;
    }
}