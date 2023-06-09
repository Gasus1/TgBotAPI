using API_IPBot2.Models;
using Npgsql;

namespace API_IPBot2
{
    public class Database
    {
        NpgsqlConnection con = new NpgsqlConnection(Constants.Connect);
        public async Task InsertIpDataAsync(IP_Data iP_Data)
        {
            var sql = "insert into public.\"IPLog\"(\"query\", \"status\", \"country\", \"regionName\", \"city\", \"lat\", \"lon\", \"isp\", \"org\", \"As\")"
                + $"values (@query, @status, @country, @regionName, @city, @lat, @lon, @isp, @org, @As)";
            NpgsqlCommand comm = new NpgsqlCommand(sql, con);
            comm.Parameters.AddWithValue("query", iP_Data.Query);
            comm.Parameters.AddWithValue("status", iP_Data.status);
            comm.Parameters.AddWithValue("country", iP_Data.country);
            comm.Parameters.AddWithValue("regionName", iP_Data.regionName);
            comm.Parameters.AddWithValue("city", iP_Data.city);
            comm.Parameters.AddWithValue("lat", iP_Data.lat);
            comm.Parameters.AddWithValue("lon", iP_Data.lon);
            comm.Parameters.AddWithValue("isp", iP_Data.isp);
            comm.Parameters.AddWithValue("org", iP_Data.org);
            comm.Parameters.AddWithValue("As", iP_Data.As);
            await con.OpenAsync();
            await comm.ExecuteNonQueryAsync();
            await con.CloseAsync();
        }
        public async Task InsertUserIpDataAsync(IP_Data iP_Data)
        {
            var sql = "insert into public.\"UserInfo\"(\"query\", \"country\", \"regionName\", \"city\", \"lat\", \"lon\", \"isp\", \"org\", \"As\")"
                + $"values (@query, @country, @regionName, @city, @lat, @lon, @isp, @org, @As)";
            NpgsqlCommand comm = new NpgsqlCommand(sql, con);
            comm.Parameters.AddWithValue("query", iP_Data.Query);
            comm.Parameters.AddWithValue("country", iP_Data.country);
            comm.Parameters.AddWithValue("regionName", iP_Data.regionName);
            comm.Parameters.AddWithValue("city", iP_Data.city);
            comm.Parameters.AddWithValue("lat", iP_Data.lat);
            comm.Parameters.AddWithValue("lon", iP_Data.lon);
            comm.Parameters.AddWithValue("isp", iP_Data.isp);
            comm.Parameters.AddWithValue("org", iP_Data.org);
            comm.Parameters.AddWithValue("As", iP_Data.As);
            await con.OpenAsync();
            await comm.ExecuteNonQueryAsync();
            await con.CloseAsync();
        }
    }
}
