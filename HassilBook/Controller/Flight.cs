using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HassilBook
{
    /// <summary>
    /// Flight search
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Searches only one single airplane economic tickets
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="dep"></param>
        /// <returns></returns>
        public List<FlightModel> SearchEconomyFromSingleAirline(string from, string to, string dep)
        {
            List<FlightModel> flightModel = new List<FlightModel>();
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT F.OfficeID, C.Company, A.RegNumber, F.FlightID, F.FlightNo, A.Model, D.Airport AS DFROM, D.City AS DepCity, PP.Airport AS DTO, PP.City AS ArrCity, CASE WHEN F.Stop IS NOT NULL THEN S.Airport ELSE 'Direct' END AS Stops, F.DepartureDate, F.DepartureTime, F.ArrivalTime, F.EconomySeats, F.BusinessSeats, P.AdultEconomy, P.AdultBusiness, P.ChildEconomy, P.ChildBusiness, P.InfantEconomy, P.InfantBusiness, F.Status, C.Logo FROM tbl_ClientFlights F
                                    INNER JOIN tbl_Airports D ON F.WhereFrom = D.ID
                                    INNER JOIN tbl_Airports PP ON F.WhereTo = PP.ID
                                    LEFT JOIN tbl_Airports S ON F.Stop = S.ID
                                    INNER JOIN tbl_ClientAirplanes A ON F.AirplaneID = A.ID
                                    INNER JOIN tbl_ClientFlightPrices P ON F.PriceTypeID = P.ID
                                    INNER JOIN tbl_Clients C ON F.OfficeID = C.ID
                                    WHERE D.Airport = '" + from + "' AND PP.Airport = '" + to + "' AND F.DepartureDate = '" + dep + "' AND F.EconomySeats > 0 AND F.OfficeID = '"+FrmLogin.m_agency.OfficeID+"' ORDER BY F.DepartureTime ASC";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    FlightModel flight = new FlightModel();
                    flight.OfficeID = int.Parse(dr["OfficeID"].ToString());
                    flight.Airlines = dr["Company"].ToString();
                    flight.RegisteredNumber = dr["RegNumber"].ToString();
                    flight.FlightID = dr["FlightID"].ToString();
                    flight.FlightNo = dr["FlightNo"].ToString();
                    flight.Model = dr["Model"].ToString();
                    flight.From = dr["DFROM"].ToString();
                    flight.CityFrom = dr["DepCity"].ToString();
                    flight.To = dr["DTO"].ToString();
                    flight.CityTo = dr["ArrCity"].ToString();
                    flight.Stops = dr["Stops"].ToString();
                    flight.DepartureDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    flight.DepartureTime = TimeSpan.Parse(dr["DepartureTime"].ToString());
                    flight.ArrivalTime = TimeSpan.Parse(dr["ArrivalTime"].ToString());
                    flight.EconomySeats = int.Parse(dr["EconomySeats"].ToString());
                    flight.BusinessSeats = int.Parse(dr["BusinessSeats"].ToString());
                    flight.AdultEconomyPrice = decimal.Parse(dr["AdultEconomy"].ToString());
                    flight.AdultBusinessPrice = decimal.Parse(dr["AdultBusiness"].ToString());
                    flight.ChildEconomyPrice = decimal.Parse(dr["ChildEconomy"].ToString());
                    flight.ChildBusinessPrice = decimal.Parse(dr["ChildBusiness"].ToString());
                    flight.InfantEconomyPrice = decimal.Parse(dr["InfantEconomy"].ToString());
                    flight.InfantBusinessPrice = decimal.Parse(dr["InfantBusiness"].ToString());
                    flight.Status = dr["Status"].ToString();
                    flight.Logo = Convert.IsDBNull(dr["Logo"]) ? null : (byte[])dr["Logo"];
                    flightModel.Add(flight);
                }
                dr.Close();
                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return flightModel;
        }
        
        /// <summary>
        /// Searches economy seats from all airlines
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="dep"></param>
        /// <returns></returns>
        public List<FlightModel> SearchEconomyFromAllAirlines(string from, string to, string dep)
        {
            List<FlightModel> flightModel = new List<FlightModel>();
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT F.OfficeID, C.Company, A.RegNumber, F.FlightID, F.FlightNo, A.Model, D.Airport AS DFROM, D.City AS DepCity, PP.Airport AS DTO, PP.City AS ArrCity, CASE WHEN F.Stop IS NOT NULL THEN S.Airport ELSE 'Direct' END AS Stops, F.DepartureDate, F.DepartureTime, F.ArrivalTime, F.EconomySeats, F.BusinessSeats, P.AdultEconomy, P.AdultBusiness, P.ChildEconomy, P.ChildBusiness, P.InfantEconomy, P.InfantBusiness, F.Status, C.Logo FROM tbl_ClientFlights F
                                    INNER JOIN tbl_Airports D ON F.WhereFrom = D.ID
                                    INNER JOIN tbl_Airports PP ON F.WhereTo = PP.ID
                                    LEFT JOIN tbl_Airports S ON F.Stop = S.ID
                                    INNER JOIN tbl_ClientAirplanes A ON F.AirplaneID = A.ID
                                    INNER JOIN tbl_ClientFlightPrices P ON F.PriceTypeID = P.ID
                                    INNER JOIN tbl_Clients C ON F.OfficeID = C.ID
                                    WHERE D.Airport = '" + from+"' AND PP.Airport = '"+to+"' AND F.DepartureDate = '"+dep+ "' AND F.EconomySeats > 0 ORDER BY F.DepartureTime ASC";
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    FlightModel flight = new FlightModel();
                    flight.OfficeID = int.Parse(dr["OfficeID"].ToString());
                    flight.Airlines = dr["Company"].ToString();
                    flight.RegisteredNumber = dr["RegNumber"].ToString();
                    flight.FlightID = dr["FlightID"].ToString();
                    flight.FlightNo = dr["FlightNo"].ToString();
                    flight.Model = dr["Model"].ToString();
                    flight.From = dr["DFROM"].ToString();
                    flight.CityFrom = dr["DepCity"].ToString();
                    flight.To = dr["DTO"].ToString();
                    flight.CityTo = dr["ArrCity"].ToString();
                    flight.Stops = dr["Stops"].ToString();
                    flight.DepartureDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    flight.DepartureTime = TimeSpan.Parse(dr["DepartureTime"].ToString());
                    flight.ArrivalTime = TimeSpan.Parse(dr["ArrivalTime"].ToString());
                    flight.EconomySeats = int.Parse(dr["EconomySeats"].ToString());
                    flight.BusinessSeats = int.Parse(dr["BusinessSeats"].ToString());
                    flight.AdultEconomyPrice = decimal.Parse(dr["AdultEconomy"].ToString());
                    flight.AdultBusinessPrice = decimal.Parse(dr["AdultBusiness"].ToString());
                    flight.ChildEconomyPrice = decimal.Parse(dr["ChildEconomy"].ToString());
                    flight.ChildBusinessPrice = decimal.Parse(dr["ChildBusiness"].ToString());
                    flight.InfantEconomyPrice = decimal.Parse(dr["InfantEconomy"].ToString());
                    flight.InfantBusinessPrice = decimal.Parse(dr["InfantBusiness"].ToString());
                    flight.Status = dr["Status"].ToString();
                    flight.Logo = Convert.IsDBNull(dr["Logo"]) ? null : (byte[])dr["Logo"];
                    flightModel.Add(flight);
                }
                dr.Close();
                con.ActiveConnection().Close();
            }
            catch (Exception)
            {

            }
            return flightModel;
        }

        /// <summary>
        /// Searches business seats from one single airplane
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="dep"></param>
        /// <returns></returns>
        public List<FlightModel> SearchBusinessFromSingleAirline(string from, string to, string dep)
        {
            List<FlightModel> flightModel = new List<FlightModel>();
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT F.OfficeID, C.Company, A.RegNumber, F.FlightID, F.FlightNo, A.Model, D.Airport AS DFROM, D.City AS DepCity, PP.Airport AS DTO, PP.City AS ArrCity, CASE WHEN F.Stop IS NOT NULL THEN S.Airport ELSE 'Direct' END AS Stops, F.DepartureDate, F.DepartureTime, F.ArrivalTime, F.EconomySeats, F.BusinessSeats, P.AdultEconomy, P.AdultBusiness, P.ChildEconomy, P.ChildBusiness, P.InfantEconomy, P.InfantBusiness, F.Status, C.Logo FROM tbl_ClientFlights F
                                    INNER JOIN tbl_Airports D ON F.WhereFrom = D.ID
                                    INNER JOIN tbl_Airports PP ON F.WhereTo = PP.ID
                                    LEFT JOIN tbl_Airports S ON F.Stop = S.ID
                                    INNER JOIN tbl_ClientAirplanes A ON F.AirplaneID = A.ID
                                    INNER JOIN tbl_ClientFlightPrices P ON F.PriceTypeID = P.ID
                                    INNER JOIN tbl_Clients C ON F.OfficeID = C.ID
                                    WHERE D.Airport = '" + from + "' AND PP.Airport = '" + to + "' AND F.DepartureDate = '" + dep + "' AND F.BusinessSeats > 0 AND F.OfficeID = '"+FrmLogin.m_agency.OfficeID+"'ORDER BY F.DepartureTime ASC";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    FlightModel flight = new FlightModel();
                    flight.OfficeID = int.Parse(dr["OfficeID"].ToString());
                    flight.Airlines = dr["Company"].ToString();
                    flight.RegisteredNumber = dr["RegNumber"].ToString();
                    flight.FlightID = dr["FlightID"].ToString();
                    flight.FlightNo = dr["FlightNo"].ToString();
                    flight.Model = dr["Model"].ToString();
                    flight.From = dr["DFROM"].ToString();
                    flight.CityFrom = dr["DepCity"].ToString();
                    flight.To = dr["DTO"].ToString();
                    flight.CityTo = dr["ArrCity"].ToString();
                    flight.Stops = dr["Stops"].ToString();
                    flight.DepartureDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    flight.DepartureTime = TimeSpan.Parse(dr["DepartureTime"].ToString());
                    flight.ArrivalTime = TimeSpan.Parse(dr["ArrivalTime"].ToString());
                    flight.EconomySeats = int.Parse(dr["EconomySeats"].ToString());
                    flight.BusinessSeats = int.Parse(dr["BusinessSeats"].ToString());
                    flight.AdultEconomyPrice = decimal.Parse(dr["AdultEconomy"].ToString());
                    flight.AdultBusinessPrice = decimal.Parse(dr["AdultBusiness"].ToString());
                    flight.ChildEconomyPrice = decimal.Parse(dr["ChildEconomy"].ToString());
                    flight.ChildBusinessPrice = decimal.Parse(dr["ChildBusiness"].ToString());
                    flight.InfantEconomyPrice = decimal.Parse(dr["InfantEconomy"].ToString());
                    flight.InfantBusinessPrice = decimal.Parse(dr["InfantBusiness"].ToString());
                    flight.Status = dr["Status"].ToString();
                    flight.Logo = Convert.IsDBNull(dr["Logo"]) ? null : (byte[])dr["Logo"];
                    flightModel.Add(flight);
                }
                dr.Close();
                con.ActiveConnection().Close();
            }
            catch (Exception)
            {

            }
            return flightModel;
        }

        /// <summary>
        /// Searches business seats from all airplanes
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="dep"></param>
        /// <returns></returns>
        public List<FlightModel> SearchBusinessFromAllAirlines(string from, string to, string dep)
        {
            List<FlightModel> flightModel = new List<FlightModel>();
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT F.OfficeID, C.Company, A.RegNumber, F.FlightID, F.FlightNo, A.Model, D.Airport AS DFROM, D.City AS DepCity, PP.Airport AS DTO, PP.City AS ArrCity, CASE WHEN F.Stop IS NOT NULL THEN S.Airport ELSE 'Direct' END AS Stops, F.DepartureDate, F.DepartureTime, F.ArrivalTime, F.EconomySeats, F.BusinessSeats, P.AdultEconomy, P.AdultBusiness, P.ChildEconomy, P.ChildBusiness, P.InfantEconomy, P.InfantBusiness, F.Status, C.Logo FROM tbl_ClientFlights F
                                    INNER JOIN tbl_Airports D ON F.WhereFrom = D.ID
                                    INNER JOIN tbl_Airports PP ON F.WhereTo = PP.ID
                                    LEFT JOIN tbl_Airports S ON F.Stop = S.ID
                                    INNER JOIN tbl_ClientAirplanes A ON F.AirplaneID = A.ID
                                    INNER JOIN tbl_ClientFlightPrices P ON F.PriceTypeID = P.ID
                                    INNER JOIN tbl_Clients C ON F.OfficeID = C.ID
                                    WHERE D.Airport = '" + from + "' AND PP.Airport = '" + to + "' AND F.DepartureDate = '" + dep + "' AND F.BusinessSeats > 0 ORDER BY F.DepartureTime ASC";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    FlightModel flight = new FlightModel();
                    flight.OfficeID = int.Parse(dr["OfficeID"].ToString());
                    flight.Airlines = dr["Company"].ToString();
                    flight.RegisteredNumber = dr["RegNumber"].ToString();
                    flight.FlightID = dr["FlightID"].ToString();
                    flight.FlightNo = dr["FlightNo"].ToString();
                    flight.Model = dr["Model"].ToString();
                    flight.From = dr["DFROM"].ToString();
                    flight.CityFrom = dr["DepCity"].ToString();
                    flight.To = dr["DTO"].ToString();
                    flight.CityTo = dr["ArrCity"].ToString();
                    flight.Stops = dr["Stops"].ToString();
                    flight.DepartureDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    flight.DepartureTime = TimeSpan.Parse(dr["DepartureTime"].ToString());
                    flight.ArrivalTime = TimeSpan.Parse(dr["ArrivalTime"].ToString());
                    flight.EconomySeats = int.Parse(dr["EconomySeats"].ToString());
                    flight.BusinessSeats = int.Parse(dr["BusinessSeats"].ToString());
                    flight.AdultEconomyPrice = decimal.Parse(dr["AdultEconomy"].ToString());
                    flight.AdultBusinessPrice = decimal.Parse(dr["AdultBusiness"].ToString());
                    flight.ChildEconomyPrice = decimal.Parse(dr["ChildEconomy"].ToString());
                    flight.ChildBusinessPrice = decimal.Parse(dr["ChildBusiness"].ToString());
                    flight.InfantEconomyPrice = decimal.Parse(dr["InfantEconomy"].ToString());
                    flight.InfantBusinessPrice = decimal.Parse(dr["InfantBusiness"].ToString());
                    flight.Status = dr["Status"].ToString();
                    flight.Logo = Convert.IsDBNull(dr["Logo"]) ? null : (byte[])dr["Logo"];
                    flightModel.Add(flight);
                }
                dr.Close();
                con.ActiveConnection().Close();
            }
            catch (Exception)
            {

            }
            return flightModel;
        }
    }
}
