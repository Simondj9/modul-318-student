namespace SwissTransport.Core
{
    using System;
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id);

        Connections GetConnections(string fromStation, string toStation);
        Connections GetConnectionsDate(string fromStation, string toStation, DateTime date, DateTime time);
        Connections GetConnectionsVia(string fromStation, string toStation, string via, DateTime date, DateTime time);
    }
}