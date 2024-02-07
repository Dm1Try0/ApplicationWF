using System.Xml.Serialization;

namespace WinFormsApp1
{
	public class SettingsData
	{

		public static SettingsData GetSettings()
		{
			SettingsData settings = null;
			string filename = Settings_File.SettingsFile;

			if (File.Exists(filename))
			{
				using (FileStream fs = new FileStream(filename, FileMode.Open))
				{
					XmlSerializer xser = new XmlSerializer(typeof(SettingsData));

					settings = (SettingsData)xser.Deserialize(fs);
					fs.Close();
				}
			}
			else settings = new SettingsData();
			return settings;
		}
		public void Save()
		{
			string filename = Settings_File.SettingsFile;
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}

			using (FileStream fs = new FileStream(filename, FileMode.Create))
			{
				XmlSerializer xser = new XmlSerializer(typeof(SettingsData));
				xser.Serialize(fs, this);
				fs.Close(); //лишнее
			}
		}
		public byte FirstStart { get; set; }
		public string ComputerName { get; set; }
		public string? private_key { get; set; }
		public bool Baf5 { get; set; }
		public bool ShopBaf { get; set; }
		public bool Baf20 { get; set; }
		public bool Baf30 { get; set; }
		public bool Baf60 { get; set; }
		public string? Baf5_file { get; set; }
		public string? ShopBaf_file { get; set; }
		public string? Baf20_file { get; set; }
		public string? Baf30_file { get; set; }
		public string? Baf60_file { get; set; }


	}
}
