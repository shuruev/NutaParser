namespace CC.PA2.VortexSync
{
	internal class RoboSuite
	{
		public bool? GetStatus(string filepath)
		{
			SqlDataReader reader;
			//return (reader["status"] is DBNull ? null : (bool?)reader["status"]);
			return reader["status"] is DBNull ? null : (bool?)reader["status"];
		}
	}
}
