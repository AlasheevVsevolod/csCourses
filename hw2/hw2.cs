using System;

namespace ConsoleApp7
{
	public class Practice
	{
		/// <summary>
		/// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
		/// </summary>
		public static void Main()
		{
			string name = "Olga";
			string hasPhoto = "True";
			string flatNumber = "34";

			char sex = 'М';
			char place = '3';
			char hasFingerPrints = '0';

			bool hasFree2Pages = false;

			double visaPrice = 60;
			double photoPrice = 7.5;

			int birthYear = 2000;

			//1. CHAR CONVERSION 
/*			char sex = 'М';
			char place = '3';
			char hasFingerPrints = '0';
*/
			//1.1 CHAR to STRING
			//string charToStringImplicit = sex;												//IMPLICIT: NOT COMPILING
			//string chartToStringExplicit = (string)sex;								//EXPLICIT: NOT COMPILING
			string charToStringUsingConverter = Convert.ToString(sex);	//CONVERT: "M"

			//1.2 CHAR to BOOL
			bool charToBool;
			//charToBool = sex;											//IMPLICIT: NOT COMPILING
			//charToBool = (char)sex;								//EXPLICIT: NOT COMPILING
			//charToBool = Convert.ToBoolean(sex);	//System.InvalidCastException: "Недопустимое приведение "Char" к "Boolean"."
			//Но можно char->int(код символа или число)->bool

			//1.3 CHAR to DECIMAL
			decimal charToDecimal;
			charToDecimal = sex;											//(dec)1052
			charToDecimal = (decimal)sex;							//(dec)1052
			//charToDecimal = Convert.ToDecimal(sex);	//System.InvalidCastException: "Недопустимое приведение "Char" к "Decimal"."
			//Но можно char->int(код символа или число)->decimal

			charToDecimal = place;					//(dec)51
			charToDecimal = (decimal)place; //(dec)51

			//1.4 CHAR to INT
			int charToInt;
			charToInt = sex;															//(int)1052
			charToInt = (int)sex;													//(int)1052
			charToInt = Convert.ToInt32(sex);							//(int)1052
			charToInt = (int)char.GetNumericValue(sex);		//(int)-1 т.к. передаём не числовой символ

			charToInt = place;														//(int)51
			charToInt = (int)place;												//(int)51
			charToInt = (int)char.GetNumericValue(place);	//(int)3

			//2. STRING CONVERSION
/*			string name = "Olga";
			string hasPhoto = "True";
			string flatNumber = "34";
*/
			//2.1 STRING to CHAR
			char strToChar;
			//strToChar = name;									//IMPLICIT: NOT COMPILING
			//strToChar = (char)name;						//EXPLICIT: NOT COMPILING
			//strToChar = Convert.ToChar(name);	//System.FormatException: "Длина строки должна составлять один знак."

			//strToChar = "6";									//IMPLICIT: NOT COMPILING
			//strToChar = (char)"6";						//EXPLICIT: NOT COMPILING
			strToChar = Convert.ToChar("6");		//(char)'6'

			//2.2 STRING to BOOL
			bool strToBool;
			//strToBool = name;												//IMPLICIT: NOT COMPILING
			//strToBool = (bool)name;									//EXPLICIT: NOT COMPILING
			//strToBool = Convert.ToBoolean(name);		//System.FormatException: "Строка не распознана как действительное логическое значение."

			//strToBool = hasPhoto;										//IMPLICIT: NOT COMPILING
			//strToBool = (bool)hasPhoto;							//EXPLICIT: NOT COMPILING
			strToBool = Convert.ToBoolean(hasPhoto);	//(bool) true

			//2.3 STRING to DECIMAL
			decimal strToDec;
			//strToDec = flatNumber;										//IMPLICIT: NOT COMPILING
			//strToDec = (decimal)flatNumber;						//EXPLICIT: NOT COMPILING
			strToDec = Convert.ToDecimal(flatNumber);		//(decimal)34
			//strToDec = Convert.ToDecimal("123.456");	//System.FormatException: "Входная строка имела неверный формат."
			strToDec = Convert.ToDecimal("123,456");		//(decimal)123.456

			//2.4 STRING to INT
			int strToInt;
			//strToInt = flatNumber;								//IMPLICIT: NOT COMPILING
			//strToInt = (int)flatNumber;						//EXPLICIT: NOT COMPILING
			strToInt = Convert.ToInt32(flatNumber); //(int)34
			//strToInt = Convert.ToInt32("123.456");//System.FormatException: "Входная строка имела неверный формат."
			//strToInt = Convert.ToInt32("123,456");//System.FormatException: "Входная строка имела неверный формат."

//3. BOOL CONVERSION
//			bool hasFree2Pages = false;

			//3.1 BOOL to CHAR
			char boolToChar;
			//boolToChar = hasFree2Pages;									//IMPLICIT: NOT COMPILING
			//boolToChar = (bool)hasFree2Pages;						//EXPLICIT: NOT COMPILING
			//boolToChar = Convert.ToChar(hasFree2Pages);	//System.InvalidCastException: "Недопустимое приведение "Boolean" к "Char"."
			//Вывод - никак, или писать что-то вроде таблицы соответствия: 0 = 'F', 1 = 'T'

			//3.2 BOOL to STRING
			string boolToString;
			//boolToString = hasFree2Pages;									//IMPLICIT: NOT COMPILING
			//boolToString = (string)hasFree2Pages;					//EXPLICIT: NOT COMPILING
			boolToString = Convert.ToString(hasFree2Pages);	//(string)"False"

			//3.3 BOOL to DECIMAL
			decimal boolToDec;
			//boolToDec = hasFree2Pages;									//IMPLICIT: NOT COMPILING
			//boolToDec = (decimal)hasFree2Pages;					//EXPLICIT: NOT COMPILING
			boolToDec = Convert.ToDecimal(hasFree2Pages);	//(decimal)0
			boolToDec = Convert.ToDecimal(true);					//(decimal)1

			//3.4 BOOL to INT
			int boolToInt;
			//boolToInt = hasFree2Pages;								//IMPLICIT: NOT COMPILING
			//boolToInt = (int)hasFree2Pages;						//EXPLICIT: NOT COMPILING
			boolToInt = Convert.ToInt32(hasFree2Pages);	//(int)0
			boolToInt = Convert.ToInt32(true);					//(int)1

			//4. DECIMAL CONVERSION
/*			double visaPrice = 60;
			double photoPrice = 7.5;
*/
			//4.1 DECIMAL to CHAR
			char decToChar;
			//decToChar = visaPrice;									//IMPLICIT: NOT COMPILING
			decToChar = (char)visaPrice;							//(char)60'<'
			//decToChar = Convert.ToChar(visaPrice);	//System.InvalidCastException: "Недопустимое приведение "Double" к "Char"."

			//decToChar = photoPrice;									//IMPLICIT: NOT COMPILING
			decToChar = (char)photoPrice;							//(char)7'\a'
			//Можно ещё с округлением через dec->int
			//decToChar = Convert.ToChar(photoPrice);	//System.InvalidCastException: "Недопустимое приведение "Double" к "Char"."

			//4.2 DECIMAL to BOOL
			bool decToBool;
			//decToBool = visaPrice;										//IMPLICIT: NOT COMPILING
			//decToBool = (bool)visaPrice;							//EXPLICIT: NOT COMPILING
			decToBool = Convert.ToBoolean(visaPrice);		//(bool)true
			decToBool = Convert.ToBoolean(photoPrice);	//(bool)true
			decToBool = Convert.ToBoolean(0.003);				//(bool)true
			decToBool = Convert.ToBoolean(0.0);					//(bool)false

			//4.3 DECIMAL to STRING
			string decToString;
			//decToString = visaPrice;									//IMPLICIT: NOT COMPILING
			//decToString = (string)visaPrice;					//EXPLICIT: NOT COMPILING
			decToString = Convert.ToString(visaPrice);	//(string)"60"
			decToString = Convert.ToString(photoPrice);	//(string)"7,5"

			//4.4 DECIMAL to INT
			int decToInt;
			//decToInt = visaPrice;									//IMPLICIT: NOT COMPILING
			decToInt = (int)visaPrice;							//(int)60
			decToInt = Convert.ToInt32(visaPrice);	//(int)60
			decToInt = (int)photoPrice;							//(int)7
			decToInt = Convert.ToInt32(photoPrice);	//(int)8

			//5. INT CONVERSION
// int birthYear = 2000;

			//5.1 INT to CHAR
			char intToChar;
			//intToChar = birthYear;								//IMPLICIT: NOT COMPILING
			intToChar = (char)birthYear;						//(char)2000'символ с кодом 2000'
			intToChar = Convert.ToChar(birthYear);	//(char)2000'символ с кодом 2000'
			intToChar = (char)60;										//(char)60'<'

			//5.2 INT to BOOL
			bool intToBool;
			//intToBool = birthYear;									//IMPLICIT: NOT COMPILING
			//intToBool = (bool)birthYear;						//EXPLICIT: NOT COMPILING
			intToBool = Convert.ToBoolean(birthYear);	//(bool)true
			intToBool = Convert.ToBoolean(0);					//(bool)false

			//5.3 INT to DECIMAL
			decimal intToDec;
			intToDec = birthYear;											//(int)2000
			intToDec = (decimal)birthYear;						//(int)2000
			intToDec = Convert.ToDecimal(birthYear);	//(int)2000

			//5.4 INT to STRING
			string intToStr;
			//intToStr = birthYear;									//IMPLICIT: NOT COMPILING
			//intToStr = (string)birthYear;					//EXPLICIT: NOT COMPILING
			intToStr = Convert.ToString(birthYear);	//(string)"2000"
		}
	}
}

