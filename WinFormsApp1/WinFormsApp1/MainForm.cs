using System.Media;

namespace WinFormsApp1
{
	public partial class WinFormsApp1 : Form
	{
		private string Baf5;
		private string ShopBaf;
		private string Baf20;
		private string Baf30;
		private string Baf60;
		private string telegramAdmin = "@r2soundAdmin";
		private string telegramBot = "R2Sound_Bot";
		SettingsData _settings = null;
		public WinFormsApp1()
		{
			InitializeComponent();
			_settings = SettingsData.GetSettings();
			_initControlls();
		}

		private void _initControlls()
		{
			// получение данных

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			switch (_settings.Baf5)
			{
				case true: Baf5 = "Включено"; pictureBox5minGREEN.Visible = true; pictureBox5minRED.Visible = false; break;
				case false: Baf5 = "Выключено"; pictureBox5minGREEN.Visible = false; pictureBox5minRED.Visible = true; break;
			}
			switch (_settings.ShopBaf)
			{
				case true: ShopBaf = "Включено"; pictureBox10minGREEN.Visible = true; pictureBox10minRED.Visible = false; break;
				case false: ShopBaf = "Выключено"; pictureBox10minGREEN.Visible = false; pictureBox10minRED.Visible = true; break;
			}
			switch (_settings.Baf20)
			{
				case true: Baf20 = "Включено"; pictureBox20minGREEN.Visible = true; pictureBox20minRED.Visible = false; break;
				case false: Baf20 = "Выключено"; pictureBox20minGREEN.Visible = false; pictureBox20minRED.Visible = true; break;
			}
			switch (_settings.Baf30)
			{
				case true: Baf30 = "Включено"; pictureBox30minGREEN.Visible = true; pictureBox30minRED.Visible = false; break;
				case false: Baf30 = "Выключено"; pictureBox30minGREEN.Visible = false; pictureBox30minRED.Visible = true; break;
			}
			switch (_settings.Baf60)
			{
				case true: Baf60 = "Включено"; pictureBox60minGREEN.Visible = true; pictureBox60minRED.Visible = false; break;
				case false: Baf60 = "Выключено"; pictureBox60minGREEN.Visible = false; pictureBox60minRED.Visible = true; break;
			}

			richTextBox1.Text = $"Загрузка всех компонентов \nЗагрузка настроек\n";

			label2.Text = "Telegram: @R2Sound";
			label1.Text = "v1.2";
			label3.Text = "R2Sound";
			label1.ForeColor = Color.BlueViolet;
			label2.ForeColor = Color.BlueViolet;
			label3.ForeColor = Color.BlueViolet;
			StartButton.ForeColor = Color.Green;
			KeyPassTextBox1.Visible = false;
			PassKeyButton.Visible = false;
			reset20mButton.Visible = false;

			if (_settings.FirstStart == 0)
			{
				_settings.ComputerName = SystemInformation.ComputerName;
				timeActivating.Visible = false;
				KeyPassTextBox1.Visible = true;
				PassKeyButton.Visible = true;
				pictureBox10minGREEN.Visible = false;
				pictureBox10minRED.Visible = false;
				pictureBox20minGREEN.Visible = false;
				pictureBox20minRED.Visible = false;
				pictureBox30minGREEN.Visible = false;
				pictureBox30minRED.Visible = false;
				pictureBox5minGREEN.Visible = false;
				pictureBox5minRED.Visible = false;
				pictureBox60minGREEN.Visible = false;
				pictureBox60minRED.Visible = false;
				baf10_status.Visible = false;
				baf20_status.Visible = false;
				baf30_status.Visible = false;
				baf5_status.Visible = false;
				baf60_status.Visible = false;
				bafff5_label.Visible = false;
				StartButton.Enabled = false;
				buttonSettings.Enabled = false;
				BAFlabel.Visible = false;
				richTextBox1.Text = "Для получения доступа введите Код доступа\nЕсли его нет, напишите администратору в телеграм";
				richTextBox1.ForeColor = Color.Red;
				_settings.Save();
				return;
			}
			if (_settings.FirstStart == 24)
			{
				using (ApplicationContext db = new ApplicationContext())
				{

					void GetKey(string keypass)
					{
						var keypassget = db.Users.FirstOrDefault(u => u.KeyPassword == keypass);
						if (keypassget == null)
						{
							richTextBox1.Text = "Ключа не существует, выключаю через 5 сек.";
							KeyPassTextBox1.Text = "Ключа не существует, выключаю через 5 сек.";

							_settings.FirstStart = 0;
							_settings.Save();
							Task.Delay(5000);
							System.Windows.Forms.Application.Exit();
							return;
						}
						if (keypassget.IsActivate == false)
						{
							richTextBox1.Text = "Ключа не существует, выключаю через 5 сек.";
							KeyPassTextBox1.Text = "Ключа не существует, выключаю через 5 сек.";

							_settings.FirstStart = 0;
							_settings.Save();
							Task.Delay(5000);
							System.Windows.Forms.Application.Exit();
							return;
						}
						DateTime time = keypassget.dateTime;
						DateTime timenow = DateTime.UtcNow;
						if (keypassget != null)
						{

							if (DateTime.UtcNow > keypassget.dateTime)
							{
								richTextBox1.Text = "Ключ истек по времени, выключаю через 5 сек.";
								KeyPassTextBox1.Text = "Ключ истек по времени, выключаю через 5 сек.";
								_settings.FirstStart = 0;
								_settings.Save();
								Task.Delay(5000);
								System.Windows.Forms.Application.Exit();
								return;
							}
						}
						if (keypassget.ComputerName != _settings.ComputerName)
						{
							richTextBox1.Text = "Ключ нельзя активировать на другом пк";
							KeyPassTextBox1.Text = "Ключ нельзя активировать на другом пк";
							_settings.FirstStart = 0;
							_settings.Save();
							Task.Delay(5000);
							System.Windows.Forms.Application.Exit();
							return;
						}

						keypassget.ComputerName = _settings.ComputerName;
						var res = time.Subtract(timenow);
						string hours = $"{res.TotalHours}";

						string[] spl = hours.Split(",");
						int timesub = Convert.ToInt32(spl[0]);
						if (timesub <= 72)
						{
							timeActivating.ForeColor = Color.Red;
						}
						if (timesub > 72)
						{
							timeActivating.ForeColor = Color.Green;
						}
						timeActivating.Text = $"Осталось: {spl[0]} ч.";
					}
					GetKey(_settings.private_key);
					return;
				}
			}
			else
			{
				_settings.FirstStart = 0;
				_settings.Save();
				System.Windows.Forms.Application.Exit();
			}
		}

		bool breaking;
		bool reset20min;
		private async void button2_Click(object sender, EventArgs e) //startbutton
		{
			if (StartButton.Text == "Стоп")
			{
				StartButton.ForeColor = Color.Green;
				breaking = true;
				StartButton.Enabled = false;
				StartButton.Text = "Останавливаю...";
				await Task.Delay(6000);
				StartButton.Text = "Старт";
				StartButton.Enabled = true;
				return;
			}
			async void start5min()
			{
				breaking = false;
				StartButton.Text = "Стоп";
				StartButton.ForeColor = Color.Red;

				if (_settings.Baf5 == true)
				{
					var exePath = AppDomain.CurrentDomain.BaseDirectory;
					var path = Path.Combine(exePath, "Sound\\5m.wav");
					string filename = path;
					if (_settings.Baf5_file == null)
					{
						using (var soundPlayer = new SoundPlayer($@"{filename}"))
						{
							soundPlayer.Play();
						}
					}
					if (_settings.Baf5_file != null)
					{
						using (var soundPlayer = new SoundPlayer($@"{_settings.Baf5_file}"))
						{
							soundPlayer.Play();
						}
					}
					while (true)
					{

						for (int i = 0; i < 49; i++)
						{
							if (breaking == true)
							{
								return;
							}
							await Task.Delay(6000);
						}
						if (_settings.Baf5_file == null)
						{
							using (var soundPlayer = new SoundPlayer($@"{filename}"))
							{
								soundPlayer.Play();
							}
						}
						if (_settings.Baf5_file != null)
						{
							using (var soundPlayer = new SoundPlayer($@"{_settings.Baf5_file}"))
							{
								soundPlayer.Play();
							}
						}
						richTextBox1.Text = richTextBox1.Text + "\n5 минут Баф.";
					}
				}
			}

			async void startShop()
			{



				if (_settings.ShopBaf == true)
				{
					var exePath = AppDomain.CurrentDomain.BaseDirectory;
					var path = Path.Combine(exePath, "Sound\\10m.wav");
					string filename = path;

					if (_settings.ShopBaf_file == null)
					{
						using (var soundPlayer = new SoundPlayer($@"{filename}"))
						{
							soundPlayer.Play();
						}
					}
					if (_settings.ShopBaf_file != null)
					{
						using (var soundPlayer = new SoundPlayer($@"{_settings.ShopBaf_file}"))
						{
							soundPlayer.Play();
						}
					}

					while (true)
					{

						for (int i = 0; i < 99; i++)
						{
							if (breaking == true)
							{
								return;
							}
							await Task.Delay(6000);
						}
						if (_settings.ShopBaf_file == null)
						{
							using (var soundPlayer = new SoundPlayer($@"{filename}"))
							{
								soundPlayer.Play();
							}
						}
						if (_settings.ShopBaf_file != null)
						{
							using (var soundPlayer = new SoundPlayer($@"{_settings.ShopBaf_file}"))
							{
								soundPlayer.Play();
							}
						}
						richTextBox1.Text = richTextBox1.Text + "\n10 минут Баф.";

					}
				}
			}
			async void startBaf20()
			{
				if (_settings.Baf20 == true)
				{
					reset20mButton.Visible = true;
					var exePath = AppDomain.CurrentDomain.BaseDirectory;
					var path = Path.Combine(exePath, "Sound\\20m.wav");
					string filename = path;
					if (_settings.Baf20_file == null)
					{
						using (var soundPlayer = new SoundPlayer($@"{filename}"))
						{
							soundPlayer.Play();
						}
					}
					if (_settings.Baf20_file != null)
					{
						using (var soundPlayer = new SoundPlayer($@"{_settings.Baf20_file}"))
						{
							soundPlayer.Play();
						}
					}
					while (true)
					{

						for (int i = 0; i < 199; i++)
						{
							if (reset20min == true)
							{
								reset20min = false;
								richTextBox1.Text = richTextBox1.Text + "\nПерезапуск 20 мин баф.";
								startBaf20();
								return;
							}
							if (breaking == true)
							{
								return;
							}
							await Task.Delay(6000);
						}
						if (_settings.Baf20_file == null)
						{
							using (var soundPlayer = new SoundPlayer($@"{filename}"))
							{
								soundPlayer.Play();
							}
						}
						if (_settings.Baf20_file != null)
						{
							using (var soundPlayer = new SoundPlayer($@"{_settings.Baf20_file}"))
							{
								soundPlayer.Play();
							}
						}
						richTextBox1.Text = richTextBox1.Text + "\n20 минут Баф.";

					}
				}

			}
			async void startBaf30()
			{
				if (_settings.Baf30 == true)
				{
					var exePath = AppDomain.CurrentDomain.BaseDirectory;
					var path = Path.Combine(exePath, "Sound\\30m.wav");
					string filename = path;

					if (_settings.Baf30_file == null)
					{
						using (var soundPlayer = new SoundPlayer($@"{filename}"))
						{
							soundPlayer.Play();
						}
					}
					if (_settings.Baf30_file != null)
					{
						using (var soundPlayer = new SoundPlayer($@"{_settings.Baf30_file}"))
						{
							soundPlayer.Play();
						}
					}

					while (true)
					{

						for (int i = 0; i < 298; i++)
						{
							if (breaking == true)
							{
								return;
							}
							await Task.Delay(6000);
						}
						if (_settings.Baf30_file == null)
						{
							using (var soundPlayer = new SoundPlayer($@"{filename}"))
							{
								soundPlayer.Play();
							}
						}
						if (_settings.Baf30_file != null)
						{
							using (var soundPlayer = new SoundPlayer($@"{_settings.Baf30_file}"))
							{
								soundPlayer.Play();
							}
						}
						richTextBox1.Text = richTextBox1.Text + "\n30 минут Баф.";
					}
				}

			}
			async void startBaf60()
			{
				if (_settings.Baf60 == true)
				{
					var exePath = AppDomain.CurrentDomain.BaseDirectory;
					var path = Path.Combine(exePath, "Sound\\60m.wav");
					string filename = path;

					if (_settings.Baf60_file == null)
					{
						using (var soundPlayer = new SoundPlayer($@"{filename}"))
						{
							soundPlayer.Play();
						}
					}
					if (_settings.Baf60_file != null)
					{
						using (var soundPlayer = new SoundPlayer($@"{_settings.Baf60_file}"))
						{
							soundPlayer.Play();
						}
					}

					while (true)
					{

						for (int i = 0; i < 600; i++) //тут 599
						{
							if (breaking == true)
							{
								return;
							}
							await Task.Delay(6000);
						}
						if (_settings.Baf60_file == null)
						{
							using (var soundPlayer = new SoundPlayer($@"{filename}"))
							{
								soundPlayer.Play();
							}
						}
						if (_settings.Baf60_file != null)
						{
							using (var soundPlayer = new SoundPlayer($@"{_settings.Baf60_file}"))
							{
								soundPlayer.Play();
							}
						}

						richTextBox1.Text = richTextBox1.Text + "\n60 минут Баф.\nЧас прошел,удачной игры";
					}
				}
			}
			start5min();
			await Task.Delay(2000);
			startShop();
			await Task.Delay(3000);
			startBaf20();
			await Task.Delay(3500);
			startBaf30();
			await Task.Delay(3000);
			startBaf60();
		}


		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{


		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			Settings_Form settings = new Settings_Form();
			settings.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}


		private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void KeyPassTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private async void PassKeyButton_Click(object sender, EventArgs e)
		{
			if (KeyPassTextBox1.Text != null)
			{
				PassKeyButton.Enabled = false;
				using (ApplicationContext db = new ApplicationContext())
				{
					async void GetKey(string keypass)
					{
						var keypassget = db.Users.FirstOrDefault(u => u.KeyPassword == keypass);
						if (keypassget == null)
						{
							richTextBox1.Text = "Ключа не существует,отключаю кнопку на 15 сек.";
							KeyPassTextBox1.Text = "Ключа не существует, отключаю кнопку на 15 сек.";
							PassKeyButton.Visible = false;
							await Task.Delay(15000);
							PassKeyButton.Visible = true;
							return;
						}
						if (keypassget != null)
						{
							DateTime time = keypassget.dateTime;
							DateTime timenow = DateTime.UtcNow;
							if (DateTime.UtcNow > keypassget.dateTime)
							{
								richTextBox1.Text = "Ключ истек по времени, отключаю кнопку на 15 сек.";
								KeyPassTextBox1.Text = "Ключ истек по времени, отключаю кнопку на 15 сек.";
								_settings.FirstStart = 0;
								_settings.Save();
								PassKeyButton.Visible = false;
								await Task.Delay(15000);
								PassKeyButton.Visible = true;
								return;
								//System.Windows.Forms.Application.Exit();

							}
							if (keypassget.IsActivate == false)
							{
								richTextBox1.Text = "Ключ не активен. Отключаю кнопку на 15 сек.";
								KeyPassTextBox1.Text = "Ключ не активен. Отключаю кнопку на 15 сек.";
								_settings.FirstStart = 0;
								_settings.Save();
								PassKeyButton.Visible = false;
								await Task.Delay(15000);
								PassKeyButton.Visible = true;
								return;
							}
							/*if (keypassget.ComputerName != null)
							{
								richTextBox1.Text = "Ключ уже используется, отключаю кнопку на 15 сек.";
								KeyPassTextBox1.Text = "Ключ уже используется, отключаю кнопку на 15 сек.";
								PassKeyButton.Enabled = false;
								await Task.Delay(15000);
								PassKeyButton.Enabled = true;
								return;
								//System.Windows.Forms.Application.Exit();

							}*/
							if (keypassget.ComputerName != null)
							{
								if (keypassget.ComputerName != _settings.ComputerName)
								{
									richTextBox1.Text = "Ключ нельзя активировать на другом пк, отключаю кнопку на 15 сек.";
									KeyPassTextBox1.Text = "Ключ нельзя активировать на другом пк, отключаю кнопку на 15 сек.";
									PassKeyButton.Visible = false;
									await Task.Delay(15000);
									PassKeyButton.Visible = true;
									return;
								}
							}

							if (keypassget.ComputerName == null || keypassget.ComputerName == _settings.ComputerName)
							{
								if (_settings.ComputerName == null)
								{
									richTextBox1.Text = "Ошибка в Имени обратитесь к Администратору";
									KeyPassTextBox1.Text = "Ошибка в Имени обратитесь к Администратору";
									PassKeyButton.Visible = false;
									return;
									//System.Windows.Forms.Application.Exit();
								}
								keypassget.ComputerName = _settings.ComputerName;
								var res = time.Subtract(timenow);

								_settings.FirstStart = 24;
								_settings.private_key = keypassget.KeyPassword;
								_settings.Save();
								db.Users.Update(keypassget);
								db.SaveChanges();
								richTextBox1.Text = "Успешная активация, перезапустите программу. Выключение через 5 сек.";
								await Task.Delay(5000);
								System.Windows.Forms.Application.Exit();
							}

						}
					}
					GetKey(KeyPassTextBox1.Text);


				}
				PassKeyButton.Enabled = true;
				//_settings.private_key = KeyPassTextBox1.Text;
				//_settings.Save();
			}
		}

		private void timeActivating_Click(object sender, EventArgs e)
		{

		}

		private void reset20mButton_Click(object sender, EventArgs e)
		{
			reset20min = true;
		}
	}
}