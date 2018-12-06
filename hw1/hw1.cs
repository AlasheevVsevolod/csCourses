using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw1
{
	class Program
	{
		static void Main(string[] args)
		{
			const int expirationTime = 3;
			bool isPhotoExist = true, isDuplicateOfPassportPhoto = true, isPhotoPasted = false;
			int photoTime = 3;

			if (isPhotoExist)
			{
				if (expirationTime < photoTime)
				{
					Console.WriteLine("Старое фото");
					MakeNewPhoto();
				}
				else
				{
					if (isDuplicateOfPassportPhoto)
					{
						Console.WriteLine("В паспорте уже есть такое фото");
						MakeNewPhoto();
					}
					else
					{
						if (!isPhotoPasted)
						{
							PastePhoto();
						}
						SendPhoto();
					}
				}
			}
			else
			{
				Console.WriteLine("Отсутствует фото");
				MakeNewPhoto();
			}
			Console.ReadKey();
		}
		
		static void MakeNewPhoto()
		{
			Console.WriteLine("Делаем новую фотку");
			PastePhoto();
			SendPhoto();
			return;
		}

		static void PastePhoto()
		{
			Console.WriteLine("Вклеиваем");
			return;
		}

		static void SendPhoto()
		{
			Console.WriteLine("Отсылаем на оплату");
			return;
		}
	}
}
