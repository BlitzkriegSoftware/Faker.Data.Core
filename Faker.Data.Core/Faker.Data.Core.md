<a name='assembly'></a>
# Faker.Data.Core

## Contents

- [Address](#T-Faker-Address 'Faker.Address')
  - [CanadianZipCode()](#M-Faker-Address-CanadianZipCode 'Faker.Address.CanadianZipCode')
  - [CityPrefix()](#M-Faker-Address-CityPrefix 'Faker.Address.CityPrefix')
  - [CitySuffix()](#M-Faker-Address-CitySuffix 'Faker.Address.CitySuffix')
  - [Country()](#M-Faker-Address-Country 'Faker.Address.Country')
  - [Province()](#M-Faker-Address-Province 'Faker.Address.Province')
  - [ProvinceAbbreviation()](#M-Faker-Address-ProvinceAbbreviation 'Faker.Address.ProvinceAbbreviation')
  - [SecondaryAddress()](#M-Faker-Address-SecondaryAddress 'Faker.Address.SecondaryAddress')
  - [State()](#M-Faker-Address-State 'Faker.Address.State')
  - [StateAbbreviation()](#M-Faker-Address-StateAbbreviation 'Faker.Address.StateAbbreviation')
  - [StreetName()](#M-Faker-Address-StreetName 'Faker.Address.StreetName')
  - [StreetSuffix()](#M-Faker-Address-StreetSuffix 'Faker.Address.StreetSuffix')
  - [USCity()](#M-Faker-Address-USCity 'Faker.Address.USCity')
  - [USCounty()](#M-Faker-Address-USCounty 'Faker.Address.USCounty')
  - [USZipCode()](#M-Faker-Address-USZipCode 'Faker.Address.USZipCode')
- [Book](#T-Faker-Book 'Faker.Book')
- [Colors](#T-Faker-Colors 'Faker.Colors')
  - [ColorString()](#M-Faker-Colors-ColorString 'Faker.Colors.ColorString')
  - [Hex()](#M-Faker-Colors-Hex 'Faker.Colors.Hex')
  - [RGB()](#M-Faker-Colors-RGB 'Faker.Colors.RGB')
  - [SystemColor()](#M-Faker-Colors-SystemColor 'Faker.Colors.SystemColor')
- [Commerce](#T-Faker-Commerce 'Faker.Commerce')
  - [Department()](#M-Faker-Commerce-Department 'Faker.Commerce.Department')
  - [Departments()](#M-Faker-Commerce-Departments 'Faker.Commerce.Departments')
  - [Departments(numberOfDepartments)](#M-Faker-Commerce-Departments-System-Int32- 'Faker.Commerce.Departments(System.Int32)')
  - [Price(min,max,decimals,symbol)](#M-Faker-Commerce-Price-System-Decimal,System-Decimal,System-Int32,System-String- 'Faker.Commerce.Price(System.Decimal,System.Decimal,System.Int32,System.String)')
  - [Price(symbol)](#M-Faker-Commerce-Price-System-String- 'Faker.Commerce.Price(System.String)')
  - [Prices(symbol)](#M-Faker-Commerce-Prices-System-String- 'Faker.Commerce.Prices(System.String)')
  - [Prices(symbol,numberOfPrices)](#M-Faker-Commerce-Prices-System-String,System-Int32- 'Faker.Commerce.Prices(System.String,System.Int32)')
  - [Product()](#M-Faker-Commerce-Product 'Faker.Commerce.Product')
  - [ProductAdjective()](#M-Faker-Commerce-ProductAdjective 'Faker.Commerce.ProductAdjective')
  - [ProductAdjectives()](#M-Faker-Commerce-ProductAdjectives 'Faker.Commerce.ProductAdjectives')
  - [ProductAdjectives(numberOfAdjectives)](#M-Faker-Commerce-ProductAdjectives-System-Int32- 'Faker.Commerce.ProductAdjectives(System.Int32)')
  - [ProductMaterial()](#M-Faker-Commerce-ProductMaterial 'Faker.Commerce.ProductMaterial')
  - [ProductMaterials()](#M-Faker-Commerce-ProductMaterials 'Faker.Commerce.ProductMaterials')
  - [ProductMaterials(numberOfMaterials)](#M-Faker-Commerce-ProductMaterials-System-Int32- 'Faker.Commerce.ProductMaterials(System.Int32)')
  - [ProductName()](#M-Faker-Commerce-ProductName 'Faker.Commerce.ProductName')
  - [ProductNames()](#M-Faker-Commerce-ProductNames 'Faker.Commerce.ProductNames')
  - [ProductNames(numberOfProductNames)](#M-Faker-Commerce-ProductNames-System-Int32- 'Faker.Commerce.ProductNames(System.Int32)')
  - [Products()](#M-Faker-Commerce-Products 'Faker.Commerce.Products')
  - [Products(numberOfProducts)](#M-Faker-Commerce-Products-System-Int32- 'Faker.Commerce.Products(System.Int32)')
- [Company](#T-Faker-Company 'Faker.Company')
  - [CatchPhrase()](#M-Faker-Company-CatchPhrase 'Faker.Company.CatchPhrase')
  - [CatchPhraseMid()](#M-Faker-Company-CatchPhraseMid 'Faker.Company.CatchPhraseMid')
  - [CatchPhrasePos()](#M-Faker-Company-CatchPhrasePos 'Faker.Company.CatchPhrasePos')
  - [CatchPhrasePre()](#M-Faker-Company-CatchPhrasePre 'Faker.Company.CatchPhrasePre')
  - [Industry()](#M-Faker-Company-Industry 'Faker.Company.Industry')
  - [Sector()](#M-Faker-Company-Sector 'Faker.Company.Sector')
  - [Suffix()](#M-Faker-Company-Suffix 'Faker.Company.Suffix')
  - [Symbol()](#M-Faker-Company-Symbol 'Faker.Company.Symbol')
- [Computer](#T-Faker-Computer 'Faker.Computer')
  - [CommonFileExt()](#M-Faker-Computer-CommonFileExt 'Faker.Computer.CommonFileExt')
  - [CommonFileName(ext)](#M-Faker-Computer-CommonFileName-System-String- 'Faker.Computer.CommonFileName(System.String)')
  - [CommonFileType()](#M-Faker-Computer-CommonFileType 'Faker.Computer.CommonFileType')
  - [Exception()](#M-Faker-Computer-Exception 'Faker.Computer.Exception')
  - [FileExt(mimeType)](#M-Faker-Computer-FileExt-System-String- 'Faker.Computer.FileExt(System.String)')
  - [FileName(ext)](#M-Faker-Computer-FileName-System-String- 'Faker.Computer.FileName(System.String)')
  - [FileType()](#M-Faker-Computer-FileType 'Faker.Computer.FileType')
  - [SemanticVersion()](#M-Faker-Computer-SemanticVersion 'Faker.Computer.SemanticVersion')
  - [Version()](#M-Faker-Computer-Version 'Faker.Computer.Version')
- [CreditCard](#T-Faker-CreditCard 'Faker.CreditCard')
  - [CreditCardType()](#M-Faker-CreditCard-CreditCardType 'Faker.CreditCard.CreditCardType')
- [Currency](#T-Faker-Currency 'Faker.Currency')
- [Dataset](#T-Faker-Models-YearAdjustable51JSON-Dataset 'Faker.Models.YearAdjustable51JSON.Dataset')
  - [Id](#P-Faker-Models-YearAdjustable51JSON-Dataset-Id 'Faker.Models.YearAdjustable51JSON.Dataset.Id')
  - [collapse](#P-Faker-Models-YearAdjustable51JSON-Dataset-collapse 'Faker.Models.YearAdjustable51JSON.Dataset.collapse')
  - [column_index](#P-Faker-Models-YearAdjustable51JSON-Dataset-column_index 'Faker.Models.YearAdjustable51JSON.Dataset.column_index')
  - [column_names](#P-Faker-Models-YearAdjustable51JSON-Dataset-column_names 'Faker.Models.YearAdjustable51JSON.Dataset.column_names')
  - [data](#P-Faker-Models-YearAdjustable51JSON-Dataset-data 'Faker.Models.YearAdjustable51JSON.Dataset.data')
  - [database_code](#P-Faker-Models-YearAdjustable51JSON-Dataset-database_code 'Faker.Models.YearAdjustable51JSON.Dataset.database_code')
  - [database_id](#P-Faker-Models-YearAdjustable51JSON-Dataset-database_id 'Faker.Models.YearAdjustable51JSON.Dataset.database_id')
  - [dataset_code](#P-Faker-Models-YearAdjustable51JSON-Dataset-dataset_code 'Faker.Models.YearAdjustable51JSON.Dataset.dataset_code')
  - [description](#P-Faker-Models-YearAdjustable51JSON-Dataset-description 'Faker.Models.YearAdjustable51JSON.Dataset.description')
  - [end_date](#P-Faker-Models-YearAdjustable51JSON-Dataset-end_date 'Faker.Models.YearAdjustable51JSON.Dataset.end_date')
  - [frequency](#P-Faker-Models-YearAdjustable51JSON-Dataset-frequency 'Faker.Models.YearAdjustable51JSON.Dataset.frequency')
  - [limit](#P-Faker-Models-YearAdjustable51JSON-Dataset-limit 'Faker.Models.YearAdjustable51JSON.Dataset.limit')
  - [name](#P-Faker-Models-YearAdjustable51JSON-Dataset-name 'Faker.Models.YearAdjustable51JSON.Dataset.name')
  - [newest_available_date](#P-Faker-Models-YearAdjustable51JSON-Dataset-newest_available_date 'Faker.Models.YearAdjustable51JSON.Dataset.newest_available_date')
  - [oldest_available_date](#P-Faker-Models-YearAdjustable51JSON-Dataset-oldest_available_date 'Faker.Models.YearAdjustable51JSON.Dataset.oldest_available_date')
  - [order](#P-Faker-Models-YearAdjustable51JSON-Dataset-order 'Faker.Models.YearAdjustable51JSON.Dataset.order')
  - [premium](#P-Faker-Models-YearAdjustable51JSON-Dataset-premium 'Faker.Models.YearAdjustable51JSON.Dataset.premium')
  - [refreshed_at](#P-Faker-Models-YearAdjustable51JSON-Dataset-refreshed_at 'Faker.Models.YearAdjustable51JSON.Dataset.refreshed_at')
  - [start_date](#P-Faker-Models-YearAdjustable51JSON-Dataset-start_date 'Faker.Models.YearAdjustable51JSON.Dataset.start_date')
  - [transform](#P-Faker-Models-YearAdjustable51JSON-Dataset-transform 'Faker.Models.YearAdjustable51JSON.Dataset.transform')
  - [type](#P-Faker-Models-YearAdjustable51JSON-Dataset-type 'Faker.Models.YearAdjustable51JSON.Dataset.type')
- [Date](#T-Faker-Date 'Faker.Date')
  - [Between(from,to)](#M-Faker-Date-Between-System-DateTime,System-DateTime- 'Faker.Date.Between(System.DateTime,System.DateTime)')
  - [Birthday(minAge,maxAge)](#M-Faker-Date-Birthday-System-Int32,System-Int32- 'Faker.Date.Birthday(System.Int32,System.Int32)')
  - [Day()](#M-Faker-Date-Day 'Faker.Date.Day')
  - [Forward(years,months,days)](#M-Faker-Date-Forward-System-Int32,System-Int32,System-Int32- 'Faker.Date.Forward(System.Int32,System.Int32,System.Int32)')
  - [Forward()](#M-Faker-Date-Forward 'Faker.Date.Forward')
  - [ForwardWithTime(years,months,days,hours,minutes,seconds)](#M-Faker-Date-ForwardWithTime-System-Int32,System-Int32,System-Int32,System-Int32,System-Int32,System-Int32- 'Faker.Date.ForwardWithTime(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)')
  - [ForwardWithTime()](#M-Faker-Date-ForwardWithTime 'Faker.Date.ForwardWithTime')
  - [Month()](#M-Faker-Date-Month 'Faker.Date.Month')
  - [MonthShort()](#M-Faker-Date-MonthShort 'Faker.Date.MonthShort')
  - [Past()](#M-Faker-Date-Past 'Faker.Date.Past')
  - [Past(years,months,days)](#M-Faker-Date-Past-System-Int32,System-Int32,System-Int32- 'Faker.Date.Past(System.Int32,System.Int32,System.Int32)')
  - [PastWithTime()](#M-Faker-Date-PastWithTime 'Faker.Date.PastWithTime')
  - [PastWithTime(years,months,days,hours,minutes,seconds)](#M-Faker-Date-PastWithTime-System-Int32,System-Int32,System-Int32,System-Int32,System-Int32,System-Int32- 'Faker.Date.PastWithTime(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)')
  - [Recent(days)](#M-Faker-Date-Recent-System-Int32- 'Faker.Date.Recent(System.Int32)')
  - [Weekday()](#M-Faker-Date-Weekday 'Faker.Date.Weekday')
  - [Year()](#M-Faker-Date-Year 'Faker.Date.Year')
- [Education](#T-Faker-Education 'Faker.Education')
  - [Major()](#M-Faker-Education-Major 'Faker.Education.Major')
- [EnumerableExtensions](#T-Faker-Extensions-EnumerableExtensions 'Faker.Extensions.EnumerableExtensions')
  - [ArrayElement\`\`1(array)](#M-Faker-Extensions-EnumerableExtensions-ArrayElement``1-``0[]- 'Faker.Extensions.EnumerableExtensions.ArrayElement``1(``0[])')
  - [Join\`\`1(items,separator)](#M-Faker-Extensions-EnumerableExtensions-Join``1-System-Collections-Generic-IEnumerable{``0},System-String- 'Faker.Extensions.EnumerableExtensions.Join``1(System.Collections.Generic.IEnumerable{``0},System.String)')
  - [RandPick\`\`1(items,itemsToTake)](#M-Faker-Extensions-EnumerableExtensions-RandPick``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'Faker.Extensions.EnumerableExtensions.RandPick``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [Rand\`\`1(items)](#M-Faker-Extensions-EnumerableExtensions-Rand``1-System-Collections-Generic-IEnumerable{``0}- 'Faker.Extensions.EnumerableExtensions.Rand``1(System.Collections.Generic.IEnumerable{``0})')
  - [Shuffle\`\`1(list)](#M-Faker-Extensions-EnumerableExtensions-Shuffle``1-System-Collections-Generic-IList{``0}- 'Faker.Extensions.EnumerableExtensions.Shuffle``1(System.Collections.Generic.IList{``0})')
- [FuelPrices](#T-Faker-FuelPrices 'Faker.FuelPrices')
  - [CompressedNaturalGas()](#M-Faker-FuelPrices-CompressedNaturalGas 'Faker.FuelPrices.CompressedNaturalGas')
  - [Diesel()](#M-Faker-FuelPrices-Diesel 'Faker.FuelPrices.Diesel')
  - [E85()](#M-Faker-FuelPrices-E85 'Faker.FuelPrices.E85')
  - [Electric()](#M-Faker-FuelPrices-Electric 'Faker.FuelPrices.Electric')
  - [GetFuelPriceData()](#M-Faker-FuelPrices-GetFuelPriceData 'Faker.FuelPrices.GetFuelPriceData')
  - [LPG()](#M-Faker-FuelPrices-LPG 'Faker.FuelPrices.LPG')
  - [LoadFuelData()](#M-Faker-FuelPrices-LoadFuelData 'Faker.FuelPrices.LoadFuelData')
  - [Midgrade()](#M-Faker-FuelPrices-Midgrade 'Faker.FuelPrices.Midgrade')
  - [Premium()](#M-Faker-FuelPrices-Premium 'Faker.FuelPrices.Premium')
  - [Regular()](#M-Faker-FuelPrices-Regular 'Faker.FuelPrices.Regular')
  - [RunRequest(url)](#M-Faker-FuelPrices-RunRequest-System-String- 'Faker.FuelPrices.RunRequest(System.String)')
- [FuelPricesModel](#T-Faker-Models-FuelPricesModel 'Faker.Models.FuelPricesModel')
  - [CompressedNaturalGas](#P-Faker-Models-FuelPricesModel-CompressedNaturalGas 'Faker.Models.FuelPricesModel.CompressedNaturalGas')
  - [Diesel](#P-Faker-Models-FuelPricesModel-Diesel 'Faker.Models.FuelPricesModel.Diesel')
  - [E85](#P-Faker-Models-FuelPricesModel-E85 'Faker.Models.FuelPricesModel.E85')
  - [Electric](#P-Faker-Models-FuelPricesModel-Electric 'Faker.Models.FuelPricesModel.Electric')
  - [LPG](#P-Faker-Models-FuelPricesModel-LPG 'Faker.Models.FuelPricesModel.LPG')
  - [Midgrade](#P-Faker-Models-FuelPricesModel-Midgrade 'Faker.Models.FuelPricesModel.Midgrade')
  - [Premium](#P-Faker-Models-FuelPricesModel-Premium 'Faker.Models.FuelPricesModel.Premium')
  - [Regular](#P-Faker-Models-FuelPricesModel-Regular 'Faker.Models.FuelPricesModel.Regular')
- [GeoLocation](#T-Faker-GeoLocation 'Faker.GeoLocation')
  - [Latitude()](#M-Faker-GeoLocation-Latitude 'Faker.GeoLocation.Latitude')
  - [Longitude()](#M-Faker-GeoLocation-Longitude 'Faker.GeoLocation.Longitude')
- [Images](#T-Faker-Images 'Faker.Images')
  - [BMP()](#M-Faker-Images-BMP 'Faker.Images.BMP')
  - [GetImage(format)](#M-Faker-Images-GetImage-System-Drawing-Imaging-ImageFormat- 'Faker.Images.GetImage(System.Drawing.Imaging.ImageFormat)')
  - [JPEG()](#M-Faker-Images-JPEG 'Faker.Images.JPEG')
  - [PNG()](#M-Faker-Images-PNG 'Faker.Images.PNG')
- [Internet](#T-Faker-Internet 'Faker.Internet')
  - [DomainSuffix()](#M-Faker-Internet-DomainSuffix 'Faker.Internet.DomainSuffix')
  - [Host()](#M-Faker-Internet-Host 'Faker.Internet.Host')
  - [IPv4()](#M-Faker-Internet-IPv4 'Faker.Internet.IPv4')
  - [IPv6()](#M-Faker-Internet-IPv6 'Faker.Internet.IPv6')
  - [LocalHost()](#M-Faker-Internet-LocalHost 'Faker.Internet.LocalHost')
  - [Mac()](#M-Faker-Internet-Mac 'Faker.Internet.Mac')
  - [Protocol()](#M-Faker-Internet-Protocol 'Faker.Internet.Protocol')
  - [TopCountryDomainSuffix()](#M-Faker-Internet-TopCountryDomainSuffix 'Faker.Internet.TopCountryDomainSuffix')
  - [TopDomainSuffix()](#M-Faker-Internet-TopDomainSuffix 'Faker.Internet.TopDomainSuffix')
- [Lorem](#T-Faker-Lorem 'Faker.Lorem')
  - [FirstCharToUpper(input)](#M-Faker-Lorem-FirstCharToUpper-System-String- 'Faker.Lorem.FirstCharToUpper(System.String)')
  - [Letter()](#M-Faker-Lorem-Letter 'Faker.Lorem.Letter')
  - [Letters(number)](#M-Faker-Lorem-Letters-System-Int32- 'Faker.Lorem.Letters(System.Int32)')
  - [Letters()](#M-Faker-Lorem-Letters 'Faker.Lorem.Letters')
  - [Paragraph(numberOfSentences)](#M-Faker-Lorem-Paragraph-System-Int32- 'Faker.Lorem.Paragraph(System.Int32)')
  - [Paragraph()](#M-Faker-Lorem-Paragraph 'Faker.Lorem.Paragraph')
  - [Paragraphs(numberOfParagraphs)](#M-Faker-Lorem-Paragraphs-System-Int32- 'Faker.Lorem.Paragraphs(System.Int32)')
  - [Paragraphs()](#M-Faker-Lorem-Paragraphs 'Faker.Lorem.Paragraphs')
  - [Sentence(numberOfWords)](#M-Faker-Lorem-Sentence-System-Int32- 'Faker.Lorem.Sentence(System.Int32)')
  - [Sentence()](#M-Faker-Lorem-Sentence 'Faker.Lorem.Sentence')
  - [Sentences(number)](#M-Faker-Lorem-Sentences-System-Int32- 'Faker.Lorem.Sentences(System.Int32)')
  - [Sentences()](#M-Faker-Lorem-Sentences 'Faker.Lorem.Sentences')
  - [Word()](#M-Faker-Lorem-Word 'Faker.Lorem.Word')
  - [Words(number)](#M-Faker-Lorem-Words-System-Int32- 'Faker.Lorem.Words(System.Int32)')
  - [Words()](#M-Faker-Lorem-Words 'Faker.Lorem.Words')
- [Movie](#T-Faker-Movie 'Faker.Movie')
- [Music](#T-Faker-Music 'Faker.Music')
- [Name](#T-Faker-Name 'Faker.Name')
  - [Ethnicity()](#M-Faker-Name-Ethnicity 'Faker.Name.Ethnicity')
  - [FemaleFirstName()](#M-Faker-Name-FemaleFirstName 'Faker.Name.FemaleFirstName')
  - [FirstName()](#M-Faker-Name-FirstName 'Faker.Name.FirstName')
  - [FullName()](#M-Faker-Name-FullName 'Faker.Name.FullName')
  - [Gender()](#M-Faker-Name-Gender 'Faker.Name.Gender')
  - [LastName()](#M-Faker-Name-LastName 'Faker.Name.LastName')
  - [MaleFirstName()](#M-Faker-Name-MaleFirstName 'Faker.Name.MaleFirstName')
- [Number](#T-Faker-Number 'Faker.Number')
  - [Bool()](#M-Faker-Number-Bool 'Faker.Number.Bool')
  - [Double()](#M-Faker-Number-Double 'Faker.Number.Double')
  - [Even(min,max)](#M-Faker-Number-Even-System-Int32,System-Int32- 'Faker.Number.Even(System.Int32,System.Int32)')
  - [NegativeNumber(max)](#M-Faker-Number-NegativeNumber-System-Int32- 'Faker.Number.NegativeNumber(System.Int32)')
  - [NextBytes(buffer)](#M-Faker-Number-NextBytes-System-Byte[]- 'Faker.Number.NextBytes(System.Byte[])')
  - [Odd(min,max)](#M-Faker-Number-Odd-System-Int32,System-Int32- 'Faker.Number.Odd(System.Int32,System.Int32)')
  - [RandomNumber(min,max)](#M-Faker-Number-RandomNumber-System-Int32,System-Int32- 'Faker.Number.RandomNumber(System.Int32,System.Int32)')
  - [RandomNumber(min,max)](#M-Faker-Number-RandomNumber-System-Int64,System-Int64- 'Faker.Number.RandomNumber(System.Int64,System.Int64)')
  - [RandomNumber(max)](#M-Faker-Number-RandomNumber-System-Int32- 'Faker.Number.RandomNumber(System.Int32)')
  - [RandomNumber()](#M-Faker-Number-RandomNumber 'Faker.Number.RandomNumber')
- [NumberExtensions](#T-Faker-Extensions-NumberExtensions 'Faker.Extensions.NumberExtensions')
  - [Times\`\`1(num,toReturn)](#M-Faker-Extensions-NumberExtensions-Times``1-System-Int32,``0- 'Faker.Extensions.NumberExtensions.Times``1(System.Int32,``0)')
  - [Times\`\`1(count,function)](#M-Faker-Extensions-NumberExtensions-Times``1-System-Int32,System-Func{System-Int32,``0}- 'Faker.Extensions.NumberExtensions.Times``1(System.Int32,System.Func{System.Int32,``0})')
  - [To(from,to)](#M-Faker-Extensions-NumberExtensions-To-System-Int32,System-Int32- 'Faker.Extensions.NumberExtensions.To(System.Int32,System.Int32)')
- [Person](#T-Faker-Person 'Faker.Person')
  - [Ssn()](#M-Faker-Person-Ssn 'Faker.Person.Ssn')
- [Phone](#T-Faker-Phone 'Faker.Phone')
  - [FormatPhoneNumber()](#M-Faker-Phone-FormatPhoneNumber 'Faker.Phone.FormatPhoneNumber')
  - [GetPhoneNumber()](#M-Faker-Phone-GetPhoneNumber 'Faker.Phone.GetPhoneNumber')
  - [GetShortPhoneNumber()](#M-Faker-Phone-GetShortPhoneNumber 'Faker.Phone.GetShortPhoneNumber')
- [Sports](#T-Faker-Sports 'Faker.Sports')
  - [SportType()](#M-Faker-Sports-SportType 'Faker.Sports.SportType')
  - [SportTypes()](#M-Faker-Sports-SportTypes 'Faker.Sports.SportTypes')
  - [SportTypes(number)](#M-Faker-Sports-SportTypes-System-Int32- 'Faker.Sports.SportTypes(System.Int32)')
- [StringExtensions](#T-Faker-Extensions-StringExtensions 'Faker.Extensions.StringExtensions')
  - [Bothify(str)](#M-Faker-Extensions-StringExtensions-Bothify-System-String- 'Faker.Extensions.StringExtensions.Bothify(System.String)')
  - [Letterify(letterString)](#M-Faker-Extensions-StringExtensions-Letterify-System-String- 'Faker.Extensions.StringExtensions.Letterify(System.String)')
  - [Numerify(numberString)](#M-Faker-Extensions-StringExtensions-Numerify-System-String- 'Faker.Extensions.StringExtensions.Numerify(System.String)')
  - [Replace(str,item,character)](#M-Faker-Extensions-StringExtensions-Replace-System-String,System-Char,System-Func{System-Char}- 'Faker.Extensions.StringExtensions.Replace(System.String,System.Char,System.Func{System.Char})')
  - [To(from,to)](#M-Faker-Extensions-StringExtensions-To-System-Char,System-Char- 'Faker.Extensions.StringExtensions.To(System.Char,System.Char)')
- [Time](#T-Faker-Time 'Faker.Time')
- [User](#T-Faker-User 'Faker.User')
  - [Email()](#M-Faker-User-Email 'Faker.User.Email')
  - [GeneratePassword(length,nonAlphaNumericChars)](#M-Faker-User-GeneratePassword-System-Int32,System-Int32- 'Faker.User.GeneratePassword(System.Int32,System.Int32)')
  - [Password(length,numberOfSpecialChars)](#M-Faker-User-Password-System-Int32,System-Int32- 'Faker.User.Password(System.Int32,System.Int32)')
  - [Password(length,useSpecialChars)](#M-Faker-User-Password-System-Int32,System-Boolean- 'Faker.User.Password(System.Int32,System.Boolean)')
  - [Password(numberOfSpecialChars)](#M-Faker-User-Password-System-Int32- 'Faker.User.Password(System.Int32)')
  - [Password()](#M-Faker-User-Password 'Faker.User.Password')
  - [Username()](#M-Faker-User-Username 'Faker.User.Username')
- [Utilities](#T-Faker-Utilities 'Faker.Utilities')
  - [AlphaNumeric()](#M-Faker-Utilities-AlphaNumeric 'Faker.Utilities.AlphaNumeric')
  - [Character()](#M-Faker-Utilities-Character 'Faker.Utilities.Character')
  - [Numerify(s)](#M-Faker-Utilities-Numerify-System-String- 'Faker.Utilities.Numerify(System.String)')
- [Vehicle](#T-Faker-Vehicle 'Faker.Vehicle')
- [XML](#T-Faker-XML 'Faker.XML')
  - [doc](#F-Faker-XML-doc 'Faker.XML.doc')
  - [docLock](#F-Faker-XML-docLock 'Faker.XML.docLock')
  - [Doc](#P-Faker-XML-Doc 'Faker.XML.Doc')
  - [GetListObject(topNode,node)](#M-Faker-XML-GetListObject-System-Xml-Linq-XName,System-Xml-Linq-XName- 'Faker.XML.GetListObject(System.Xml.Linq.XName,System.Xml.Linq.XName)')
  - [GetListString(node)](#M-Faker-XML-GetListString-System-Xml-Linq-XName- 'Faker.XML.GetListString(System.Xml.Linq.XName)')
  - [GetListString(topNode,node)](#M-Faker-XML-GetListString-System-Xml-Linq-XName,System-Xml-Linq-XName- 'Faker.XML.GetListString(System.Xml.Linq.XName,System.Xml.Linq.XName)')
- [YearAdjustable51](#T-Faker-Models-YearAdjustable51 'Faker.Models.YearAdjustable51')
  - [Date](#P-Faker-Models-YearAdjustable51-Date 'Faker.Models.YearAdjustable51.Date')
  - [Percentage](#P-Faker-Models-YearAdjustable51-Percentage 'Faker.Models.YearAdjustable51.Percentage')
- [YearAdjustable51JSON](#T-Faker-Models-YearAdjustable51JSON 'Faker.Models.YearAdjustable51JSON')
  - [DataSet](#P-Faker-Models-YearAdjustable51JSON-DataSet 'Faker.Models.YearAdjustable51JSON.DataSet')

<a name='T-Faker-Address'></a>
## Address `type`

##### Namespace

Faker

##### Summary

Static class for addresses

<a name='M-Faker-Address-CanadianZipCode'></a>
### CanadianZipCode() `method`

##### Summary

Gets a random Canadian zip

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-CityPrefix'></a>
### CityPrefix() `method`

##### Summary

Gets a random city prefix

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-CitySuffix'></a>
### CitySuffix() `method`

##### Summary

Gets a random city suffix

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-Country'></a>
### Country() `method`

##### Summary

Gets a random country

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-Province'></a>
### Province() `method`

##### Summary

Gets a random province

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-ProvinceAbbreviation'></a>
### ProvinceAbbreviation() `method`

##### Summary

Gets a random province abbreviation

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-SecondaryAddress'></a>
### SecondaryAddress() `method`

##### Summary

Gets a random secondary address

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-State'></a>
### State() `method`

##### Summary

Gets a random state

##### Returns

String of a state

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-StateAbbreviation'></a>
### StateAbbreviation() `method`

##### Summary

Gets a random state abbreviation

##### Returns

String of state abbreviation

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-StreetName'></a>
### StreetName() `method`

##### Summary

Gets a random street name

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-StreetSuffix'></a>
### StreetSuffix() `method`

##### Summary

Gets a random street suffix

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-USCity'></a>
### USCity() `method`

##### Summary

Gets a random United States city

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-USCounty'></a>
### USCounty() `method`

##### Summary

Gets a random United States county

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Address-USZipCode'></a>
### USZipCode() `method`

##### Summary

Gets a random united states zip code

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='T-Faker-Book'></a>
## Book `type`

##### Namespace

Faker

##### Summary

Static book class

<a name='T-Faker-Colors'></a>
## Colors `type`

##### Namespace

Faker

##### Summary

Static color class

<a name='M-Faker-Colors-ColorString'></a>
### ColorString() `method`

##### Summary

Gets a random color

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Colors-Hex'></a>
### Hex() `method`

##### Summary

Get a random HEX number

##### Returns

A HEX number as a string

##### Parameters

This method has no parameters.

<a name='M-Faker-Colors-RGB'></a>
### RGB() `method`

##### Summary

Get a set of RGB colors

##### Returns

Returns an integer array of numbers 0 - 255

##### Parameters

This method has no parameters.

<a name='M-Faker-Colors-SystemColor'></a>
### SystemColor() `method`

##### Summary

Gets a random system color

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='T-Faker-Commerce'></a>
## Commerce `type`

##### Namespace

Faker

##### Summary

Static Commerce class

<a name='M-Faker-Commerce-Department'></a>
### Department() `method`

##### Summary

Gets a random department

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Commerce-Departments'></a>
### Departments() `method`

##### Summary

Gets a list of random departments

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

This method has no parameters.

<a name='M-Faker-Commerce-Departments-System-Int32-'></a>
### Departments(numberOfDepartments) `method`

##### Summary

Gets a list of random departments

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberOfDepartments | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of departments |

<a name='M-Faker-Commerce-Price-System-Decimal,System-Decimal,System-Int32,System-String-'></a>
### Price(min,max,decimals,symbol) `method`

##### Summary

Gets a random price

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Minimum amount |
| max | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Maximum amount |
| decimals | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of decimals |
| symbol | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Symbol to append |

<a name='M-Faker-Commerce-Price-System-String-'></a>
### Price(symbol) `method`

##### Summary

Gets a random price

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| symbol | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Symbol to append |

<a name='M-Faker-Commerce-Prices-System-String-'></a>
### Prices(symbol) `method`

##### Summary

Gets a list of random product prices

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| symbol | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Symbol to append |

<a name='M-Faker-Commerce-Prices-System-String,System-Int32-'></a>
### Prices(symbol,numberOfPrices) `method`

##### Summary

Gets a list of random product prices

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| symbol | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Symbol to append |
| numberOfPrices | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of prices |

<a name='M-Faker-Commerce-Product'></a>
### Product() `method`

##### Summary

Gets a random product

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Commerce-ProductAdjective'></a>
### ProductAdjective() `method`

##### Summary

Gets a random product adjective

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Commerce-ProductAdjectives'></a>
### ProductAdjectives() `method`

##### Summary

Gets a list of random product adjectives

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

This method has no parameters.

<a name='M-Faker-Commerce-ProductAdjectives-System-Int32-'></a>
### ProductAdjectives(numberOfAdjectives) `method`

##### Summary

Gets a list of random product adjectives

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberOfAdjectives | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of adjectives |

<a name='M-Faker-Commerce-ProductMaterial'></a>
### ProductMaterial() `method`

##### Summary

Gets a random product material

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Commerce-ProductMaterials'></a>
### ProductMaterials() `method`

##### Summary

Gets a list of random product materials

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

This method has no parameters.

<a name='M-Faker-Commerce-ProductMaterials-System-Int32-'></a>
### ProductMaterials(numberOfMaterials) `method`

##### Summary

Gets a list of random product materials

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberOfMaterials | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of materials |

<a name='M-Faker-Commerce-ProductName'></a>
### ProductName() `method`

##### Summary

Gets a random product name

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Commerce-ProductNames'></a>
### ProductNames() `method`

##### Summary

Gets a list of random product names

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

This method has no parameters.

<a name='M-Faker-Commerce-ProductNames-System-Int32-'></a>
### ProductNames(numberOfProductNames) `method`

##### Summary

Gets a list of random product names

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberOfProductNames | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of names |

<a name='M-Faker-Commerce-Products'></a>
### Products() `method`

##### Summary

Gets a list of random products

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

This method has no parameters.

<a name='M-Faker-Commerce-Products-System-Int32-'></a>
### Products(numberOfProducts) `method`

##### Summary

Gets a list of random products

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberOfProducts | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of products |

<a name='T-Faker-Company'></a>
## Company `type`

##### Namespace

Faker

##### Summary

Static company class

<a name='M-Faker-Company-CatchPhrase'></a>
### CatchPhrase() `method`

##### Summary

Method to get a catch phrase

##### Returns

String of catch phrase

##### Parameters

This method has no parameters.

<a name='M-Faker-Company-CatchPhraseMid'></a>
### CatchPhraseMid() `method`

##### Summary

Gets the mid catch phrase

##### Returns

String value

##### Parameters

This method has no parameters.

<a name='M-Faker-Company-CatchPhrasePos'></a>
### CatchPhrasePos() `method`

##### Summary

Gets the post catch phrase

##### Returns

String value

##### Parameters

This method has no parameters.

<a name='M-Faker-Company-CatchPhrasePre'></a>
### CatchPhrasePre() `method`

##### Summary

Gets the pre catch phrase

##### Returns

String value

##### Parameters

This method has no parameters.

<a name='M-Faker-Company-Industry'></a>
### Industry() `method`

##### Summary

Gets a random industry

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Company-Sector'></a>
### Sector() `method`

##### Summary

Gets a random sector

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Company-Suffix'></a>
### Suffix() `method`

##### Summary

Gets a suffix value

##### Returns

String of suffix

##### Parameters

This method has no parameters.

<a name='M-Faker-Company-Symbol'></a>
### Symbol() `method`

##### Summary

Gets a random symbol

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='T-Faker-Computer'></a>
## Computer `type`

##### Namespace

Faker

##### Summary

Static class for computer generation

<a name='M-Faker-Computer-CommonFileExt'></a>
### CommonFileExt() `method`

##### Summary

Returns a commonly used file extension

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Computer-CommonFileName-System-String-'></a>
### CommonFileName(ext) `method`

##### Summary

Gets a common filename

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ext | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An extension |

<a name='M-Faker-Computer-CommonFileType'></a>
### CommonFileType() `method`

##### Summary

Returns a commonly used file type

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Computer-Exception'></a>
### Exception() `method`

##### Summary

Get a random \`Exception\` with a fake stack trace.

##### Returns

A [Exception](#M-Faker-Computer-Exception 'Faker.Computer.Exception')

##### Parameters

This method has no parameters.

<a name='M-Faker-Computer-FileExt-System-String-'></a>
### FileExt(mimeType) `method`

##### Summary

Gets a random extension for the given mime type.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mimeType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A meme type |

<a name='M-Faker-Computer-FileName-System-String-'></a>
### FileName(ext) `method`

##### Summary

Get a random file name

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ext | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An extension |

<a name='M-Faker-Computer-FileType'></a>
### FileType() `method`

##### Summary

Returns any file type available as mime-type

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Computer-SemanticVersion'></a>
### SemanticVersion() `method`

##### Summary

Get a random Semantic Version version string.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Computer-Version'></a>
### Version() `method`

##### Summary

Get a random \`System.Version\`

##### Returns

A [Version](#M-Faker-Computer-Version 'Faker.Computer.Version')

##### Parameters

This method has no parameters.

<a name='T-Faker-CreditCard'></a>
## CreditCard `type`

##### Namespace

Faker

##### Summary

Credit card class

<a name='M-Faker-CreditCard-CreditCardType'></a>
### CreditCardType() `method`

##### Summary

Gets a random credit card type

##### Returns

string of random credit card

##### Parameters

This method has no parameters.

<a name='T-Faker-Currency'></a>
## Currency `type`

##### Namespace

Faker

##### Summary

Static currency class

<a name='T-Faker-Models-YearAdjustable51JSON-Dataset'></a>
## Dataset `type`

##### Namespace

Faker.Models.YearAdjustable51JSON

##### Summary

Dataset

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-Id'></a>
### Id `property`

##### Summary

Id

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-collapse'></a>
### collapse `property`

##### Summary

collapse

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-column_index'></a>
### column_index `property`

##### Summary

column_index

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-column_names'></a>
### column_names `property`

##### Summary

column_names

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-data'></a>
### data `property`

##### Summary

data

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-database_code'></a>
### database_code `property`

##### Summary

database_code

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-database_id'></a>
### database_id `property`

##### Summary

database_id

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-dataset_code'></a>
### dataset_code `property`

##### Summary

dataset_code

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-description'></a>
### description `property`

##### Summary

description

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-end_date'></a>
### end_date `property`

##### Summary

end_date

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-frequency'></a>
### frequency `property`

##### Summary

frequency

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-limit'></a>
### limit `property`

##### Summary

limit

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-name'></a>
### name `property`

##### Summary

name

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-newest_available_date'></a>
### newest_available_date `property`

##### Summary

newest_available_date

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-oldest_available_date'></a>
### oldest_available_date `property`

##### Summary

oldest_available_date

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-order'></a>
### order `property`

##### Summary

order

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-premium'></a>
### premium `property`

##### Summary

premium

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-refreshed_at'></a>
### refreshed_at `property`

##### Summary

refreshed_at

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-start_date'></a>
### start_date `property`

##### Summary

start_date

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-transform'></a>
### transform `property`

##### Summary

transform

<a name='P-Faker-Models-YearAdjustable51JSON-Dataset-type'></a>
### type `property`

##### Summary

type

<a name='T-Faker-Date'></a>
## Date `type`

##### Namespace

Faker

##### Summary

Class for date generation

<a name='M-Faker-Date-Between-System-DateTime,System-DateTime-'></a>
### Between(from,to) `method`

##### Summary

Gets a random [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') between two dates

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The from value |
| to | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The to value |

<a name='M-Faker-Date-Birthday-System-Int32,System-Int32-'></a>
### Birthday(minAge,maxAge) `method`

##### Summary

Gets a random birthday based on age

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| minAge | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minimum age |
| maxAge | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximum age |

<a name='M-Faker-Date-Day'></a>
### Day() `method`

##### Summary

Gets a random day

##### Returns

An integer

##### Parameters

This method has no parameters.

<a name='M-Faker-Date-Forward-System-Int32,System-Int32,System-Int32-'></a>
### Forward(years,months,days) `method`

##### Summary

Gets a random date in the future

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| years | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Years forward |
| months | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Months forward |
| days | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Days forward |

<a name='M-Faker-Date-Forward'></a>
### Forward() `method`

##### Summary

Gets a random date in the future

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

This method has no parameters.

<a name='M-Faker-Date-ForwardWithTime-System-Int32,System-Int32,System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### ForwardWithTime(years,months,days,hours,minutes,seconds) `method`

##### Summary

Gets a random date and time in the future

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| years | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Years forward |
| months | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Months forward |
| days | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Days forward |
| hours | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Hours forward |
| minutes | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minutes forward |
| seconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Seconds forward |

<a name='M-Faker-Date-ForwardWithTime'></a>
### ForwardWithTime() `method`

##### Summary

Gets a random date and time in the future

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

This method has no parameters.

<a name='M-Faker-Date-Month'></a>
### Month() `method`

##### Summary

Gets a random long month

##### Returns

A string

##### Parameters

This method has no parameters.

<a name='M-Faker-Date-MonthShort'></a>
### MonthShort() `method`

##### Summary

Gets a random short month

##### Returns

A string

##### Parameters

This method has no parameters.

<a name='M-Faker-Date-Past'></a>
### Past() `method`

##### Summary

Gets a random date in the past

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

This method has no parameters.

<a name='M-Faker-Date-Past-System-Int32,System-Int32,System-Int32-'></a>
### Past(years,months,days) `method`

##### Summary

Gets a random date and time in the past

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| years | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Years forward |
| months | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Months forward |
| days | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Days forward |

<a name='M-Faker-Date-PastWithTime'></a>
### PastWithTime() `method`

##### Summary

Gets a random date and time in the future

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

This method has no parameters.

<a name='M-Faker-Date-PastWithTime-System-Int32,System-Int32,System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### PastWithTime(years,months,days,hours,minutes,seconds) `method`

##### Summary

Gets a random date and time in the past

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| years | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Years forward |
| months | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Months forward |
| days | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Days forward |
| hours | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Hours forward |
| minutes | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minutes forward |
| seconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Seconds forward |

<a name='M-Faker-Date-Recent-System-Int32-'></a>
### Recent(days) `method`

##### Summary

Gets a recent date and time

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| days | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Days recent |

<a name='M-Faker-Date-Weekday'></a>
### Weekday() `method`

##### Summary

Gets a random weekday

##### Returns

A string

##### Parameters

This method has no parameters.

<a name='M-Faker-Date-Year'></a>
### Year() `method`

##### Summary

Gets a random year

##### Returns

An integer

##### Parameters

This method has no parameters.

<a name='T-Faker-Education'></a>
## Education `type`

##### Namespace

Faker

##### Summary

Static education class

<a name='M-Faker-Education-Major'></a>
### Major() `method`

##### Summary

Gets a random major

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='T-Faker-Extensions-EnumerableExtensions'></a>
## EnumerableExtensions `type`

##### Namespace

Faker.Extensions

##### Summary

Enumerable Extensions class

<a name='M-Faker-Extensions-EnumerableExtensions-ArrayElement``1-``0[]-'></a>
### ArrayElement\`\`1(array) `method`

##### Summary

Gets a random array element

##### Returns

A random Type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The array |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | A type |

<a name='M-Faker-Extensions-EnumerableExtensions-Join``1-System-Collections-Generic-IEnumerable{``0},System-String-'></a>
### Join\`\`1(items,separator) `method`

##### Summary

Join method of list to string

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Item list |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Separator string |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type |

<a name='M-Faker-Extensions-EnumerableExtensions-RandPick``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### RandPick\`\`1(items,itemsToTake) `method`

##### Summary

Randomly picks a number of elements from a list

##### Returns

A [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') with the specified number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | List of items |
| itemsToTake | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of items to take |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type |

<a name='M-Faker-Extensions-EnumerableExtensions-Rand``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### Rand\`\`1(items) `method`

##### Summary

Picks a random type from the list

##### Returns

Type T to Return

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | List of items |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type |

<a name='M-Faker-Extensions-EnumerableExtensions-Shuffle``1-System-Collections-Generic-IList{``0}-'></a>
### Shuffle\`\`1(list) `method`

##### Summary

Shuffles a list

##### Returns

A [IList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList`1 'System.Collections.Generic.IList`1')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | A list |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | A type |

<a name='T-Faker-FuelPrices'></a>
## FuelPrices `type`

##### Namespace

Faker

##### Summary

Static fuel prices class

<a name='M-Faker-FuelPrices-CompressedNaturalGas'></a>
### CompressedNaturalGas() `method`

##### Summary

Gets a compressed natural gas on today's date

##### Returns

A [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

This method has no parameters.

<a name='M-Faker-FuelPrices-Diesel'></a>
### Diesel() `method`

##### Summary

Gets a diesel on today's date

##### Returns

A [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

This method has no parameters.

<a name='M-Faker-FuelPrices-E85'></a>
### E85() `method`

##### Summary

Gets a E85 on today's date

##### Returns

A [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

This method has no parameters.

<a name='M-Faker-FuelPrices-Electric'></a>
### Electric() `method`

##### Summary

Gets a electric on today's date

##### Returns

A [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

This method has no parameters.

<a name='M-Faker-FuelPrices-GetFuelPriceData'></a>
### GetFuelPriceData() `method`

##### Summary

Checks to see if the data exists, if not call the API

##### Parameters

This method has no parameters.

<a name='M-Faker-FuelPrices-LPG'></a>
### LPG() `method`

##### Summary

Gets a LPG on today's date

##### Returns

A [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

This method has no parameters.

<a name='M-Faker-FuelPrices-LoadFuelData'></a>
### LoadFuelData() `method`

##### Summary

Makes an API call if provided to pull data

##### Parameters

This method has no parameters.

<a name='M-Faker-FuelPrices-Midgrade'></a>
### Midgrade() `method`

##### Summary

Gets a midgrade on today's date

##### Returns

A [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

This method has no parameters.

<a name='M-Faker-FuelPrices-Premium'></a>
### Premium() `method`

##### Summary

Gets a premium on today's date

##### Returns

A [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

This method has no parameters.

<a name='M-Faker-FuelPrices-Regular'></a>
### Regular() `method`

##### Summary

Gets a regular on today's date

##### Returns

A [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

This method has no parameters.

<a name='M-Faker-FuelPrices-RunRequest-System-String-'></a>
### RunRequest(url) `method`

##### Summary

Runs the request

##### Returns

A [HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | URL to use |

<a name='T-Faker-Models-FuelPricesModel'></a>
## FuelPricesModel `type`

##### Namespace

Faker.Models

##### Summary

Model: Fuel Prices

<a name='P-Faker-Models-FuelPricesModel-CompressedNaturalGas'></a>
### CompressedNaturalGas `property`

##### Summary

Compressed Natural Gas

<a name='P-Faker-Models-FuelPricesModel-Diesel'></a>
### Diesel `property`

##### Summary

Diesel

<a name='P-Faker-Models-FuelPricesModel-E85'></a>
### E85 `property`

##### Summary

E85

<a name='P-Faker-Models-FuelPricesModel-Electric'></a>
### Electric `property`

##### Summary

Electric

<a name='P-Faker-Models-FuelPricesModel-LPG'></a>
### LPG `property`

##### Summary

LPG

<a name='P-Faker-Models-FuelPricesModel-Midgrade'></a>
### Midgrade `property`

##### Summary

Midgrade

<a name='P-Faker-Models-FuelPricesModel-Premium'></a>
### Premium `property`

##### Summary

Premium

<a name='P-Faker-Models-FuelPricesModel-Regular'></a>
### Regular `property`

##### Summary

Regular

<a name='T-Faker-GeoLocation'></a>
## GeoLocation `type`

##### Namespace

Faker

##### Summary

Geographic Location class

<a name='M-Faker-GeoLocation-Latitude'></a>
### Latitude() `method`

##### Summary

Gets a random latitude between -90 to 90

##### Returns

Double of latitude value between -90 to 90

##### Parameters

This method has no parameters.

<a name='M-Faker-GeoLocation-Longitude'></a>
### Longitude() `method`

##### Summary

Gets a random longitude between -180 to 180

##### Returns

Double of longitude value between -180 to 180

##### Parameters

This method has no parameters.

<a name='T-Faker-Images'></a>
## Images `type`

##### Namespace

Faker

##### Summary

Static images class

<a name='M-Faker-Images-BMP'></a>
### BMP() `method`

##### Summary

Gets a BMP image

##### Returns

An image of format BMP

##### Parameters

This method has no parameters.

<a name='M-Faker-Images-GetImage-System-Drawing-Imaging-ImageFormat-'></a>
### GetImage(format) `method`

##### Summary

Gets the image

##### Returns

An image of specified image format

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.Drawing.Imaging.ImageFormat](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Imaging.ImageFormat 'System.Drawing.Imaging.ImageFormat') | Format to implement |

<a name='M-Faker-Images-JPEG'></a>
### JPEG() `method`

##### Summary

Gets an JPEG image

##### Returns

An image of format JPEG

##### Parameters

This method has no parameters.

<a name='M-Faker-Images-PNG'></a>
### PNG() `method`

##### Summary

Gets a PNG image

##### Returns

An image of format PNG

##### Parameters

This method has no parameters.

<a name='T-Faker-Internet'></a>
## Internet `type`

##### Namespace

Faker

##### Summary

Static internet class

<a name='M-Faker-Internet-DomainSuffix'></a>
### DomainSuffix() `method`

##### Summary

Gets a random  domain suffix

##### Returns

Domain suffix as string

##### Parameters

This method has no parameters.

<a name='M-Faker-Internet-Host'></a>
### Host() `method`

##### Summary

Gets a random host

##### Returns

Host as string

##### Parameters

This method has no parameters.

<a name='M-Faker-Internet-IPv4'></a>
### IPv4() `method`

##### Summary

Gets a random IP v4 address

##### Returns

IP v4 address as string

##### Parameters

This method has no parameters.

<a name='M-Faker-Internet-IPv6'></a>
### IPv6() `method`

##### Summary

Gets a random IP v6 address

##### Returns

IP v6 address as string

##### Parameters

This method has no parameters.

<a name='M-Faker-Internet-LocalHost'></a>
### LocalHost() `method`

##### Summary

Gets the local host address

##### Returns

Local host address as string

##### Parameters

This method has no parameters.

<a name='M-Faker-Internet-Mac'></a>
### Mac() `method`

##### Summary

Gets a random MAC address

##### Returns

MAC address as string

##### Parameters

This method has no parameters.

<a name='M-Faker-Internet-Protocol'></a>
### Protocol() `method`

##### Summary

Gets a random protocol

##### Returns

Protocol as string

##### Parameters

This method has no parameters.

<a name='M-Faker-Internet-TopCountryDomainSuffix'></a>
### TopCountryDomainSuffix() `method`

##### Summary

Gets a random top country domain suffix

##### Returns

Top country domain suffix as string

##### Parameters

This method has no parameters.

<a name='M-Faker-Internet-TopDomainSuffix'></a>
### TopDomainSuffix() `method`

##### Summary

Gets a random top domain suffix

##### Returns

Top domain suffix as string

##### Parameters

This method has no parameters.

<a name='T-Faker-Lorem'></a>
## Lorem `type`

##### Namespace

Faker

##### Summary

Static word class

<a name='M-Faker-Lorem-FirstCharToUpper-System-String-'></a>
### FirstCharToUpper(input) `method`

##### Summary

Method to take a string and make the first char uppercase

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String input |

<a name='M-Faker-Lorem-Letter'></a>
### Letter() `method`

##### Summary

Gets a random letter

##### Returns

A [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char')

##### Parameters

This method has no parameters.

<a name='M-Faker-Lorem-Letters-System-Int32-'></a>
### Letters(number) `method`

##### Summary

Gets a number of random letters

##### Returns

A list of [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of letters |

<a name='M-Faker-Lorem-Letters'></a>
### Letters() `method`

##### Summary

Gets a random amount of letters

##### Returns

A list of [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char')

##### Parameters

This method has no parameters.

<a name='M-Faker-Lorem-Paragraph-System-Int32-'></a>
### Paragraph(numberOfSentences) `method`

##### Summary

Gets a paragraph with a number of sentences

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberOfSentences | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of sentences |

<a name='M-Faker-Lorem-Paragraph'></a>
### Paragraph() `method`

##### Summary

Gets a paragraph with a random number of sentences

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Lorem-Paragraphs-System-Int32-'></a>
### Paragraphs(numberOfParagraphs) `method`

##### Summary

Gets a number of paragraphs with random amount of sentences

##### Returns

A list of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberOfParagraphs | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of paragraphs |

<a name='M-Faker-Lorem-Paragraphs'></a>
### Paragraphs() `method`

##### Summary

Gets a random number of paragraphs with random amount of sentences

##### Returns

A list of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Lorem-Sentence-System-Int32-'></a>
### Sentence(numberOfWords) `method`

##### Summary

Gets a sentence with a number of words

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberOfWords | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of words |

<a name='M-Faker-Lorem-Sentence'></a>
### Sentence() `method`

##### Summary

Gets a sentence with a random number of words

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Lorem-Sentences-System-Int32-'></a>
### Sentences(number) `method`

##### Summary

Gets a number of sentences

##### Returns

A list of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of sentences |

<a name='M-Faker-Lorem-Sentences'></a>
### Sentences() `method`

##### Summary

Gets a random number of sentences

##### Returns

A list of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Lorem-Word'></a>
### Word() `method`

##### Summary

Gets a random word from the list

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Lorem-Words-System-Int32-'></a>
### Words(number) `method`

##### Summary

Gets a list of words

##### Returns

A list of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of words |

<a name='M-Faker-Lorem-Words'></a>
### Words() `method`

##### Summary

Gets a random amount of words

##### Returns

A list of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='T-Faker-Movie'></a>
## Movie `type`

##### Namespace

Faker

##### Summary

Static movie class

<a name='T-Faker-Music'></a>
## Music `type`

##### Namespace

Faker

##### Summary

Static music class

<a name='T-Faker-Name'></a>
## Name `type`

##### Namespace

Faker

##### Summary

Static name class

<a name='M-Faker-Name-Ethnicity'></a>
### Ethnicity() `method`

##### Summary

Gets a random ethnicity

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Name-FemaleFirstName'></a>
### FemaleFirstName() `method`

##### Summary

Gets a random female first name

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Name-FirstName'></a>
### FirstName() `method`

##### Summary

Gets a random first name

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Name-FullName'></a>
### FullName() `method`

##### Summary

Gets a random full name

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Name-Gender'></a>
### Gender() `method`

##### Summary

Gets a random gender

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Name-LastName'></a>
### LastName() `method`

##### Summary

Gets a random last name

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='M-Faker-Name-MaleFirstName'></a>
### MaleFirstName() `method`

##### Summary

Gets a random male first name

##### Returns

A string value

##### Parameters

This method has no parameters.

<a name='T-Faker-Number'></a>
## Number `type`

##### Namespace

Faker

##### Summary

Number class used to generate random numbers

<a name='M-Faker-Number-Bool'></a>
### Bool() `method`

##### Summary

Gets a random boolean value

##### Returns

Boolean of true or false

##### Parameters

This method has no parameters.

<a name='M-Faker-Number-Double'></a>
### Double() `method`

##### Summary

Gets the next double

##### Returns

Random double value

##### Parameters

This method has no parameters.

<a name='M-Faker-Number-Even-System-Int32,System-Int32-'></a>
### Even(min,max) `method`

##### Summary

Gets the next even number

##### Returns

Integer of even number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minimum value |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximum value |

<a name='M-Faker-Number-NegativeNumber-System-Int32-'></a>
### NegativeNumber(max) `method`

##### Summary

Gets a random negative number.  Pass in a positive value

##### Returns

A negative integer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Max number positive |

<a name='M-Faker-Number-NextBytes-System-Byte[]-'></a>
### NextBytes(buffer) `method`

##### Summary

Method to get the next bytes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| buffer | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | Byte Array |

<a name='M-Faker-Number-Odd-System-Int32,System-Int32-'></a>
### Odd(min,max) `method`

##### Summary

Gets the next odd number

##### Returns

Integer of old number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minimum value |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximum value |

<a name='M-Faker-Number-RandomNumber-System-Int32,System-Int32-'></a>
### RandomNumber(min,max) `method`

##### Summary

Gets a random number

##### Returns

Integer of the random number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minimum value |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximum value |

<a name='M-Faker-Number-RandomNumber-System-Int64,System-Int64-'></a>
### RandomNumber(min,max) `method`

##### Summary

Method to get a random long value

##### Returns

A [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Minimum long |
| max | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Maximum long |

<a name='M-Faker-Number-RandomNumber-System-Int32-'></a>
### RandomNumber(max) `method`

##### Summary

Gets a random number from 0 to max variable

##### Returns

Integer number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Max integer to use |

<a name='M-Faker-Number-RandomNumber'></a>
### RandomNumber() `method`

##### Summary

Gets a random number from 0 to any

##### Returns

Integer number

##### Parameters

This method has no parameters.

<a name='T-Faker-Extensions-NumberExtensions'></a>
## NumberExtensions `type`

##### Namespace

Faker.Extensions

##### Summary

Static number extensions class

<a name='M-Faker-Extensions-NumberExtensions-Times``1-System-Int32,``0-'></a>
### Times\`\`1(num,toReturn) `method`

##### Summary

Gets a set number of times for a type

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') list

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |
| toReturn | [\`\`0](#T-``0 '``0') | Type T to return |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any Type |

<a name='M-Faker-Extensions-NumberExtensions-Times``1-System-Int32,System-Func{System-Int32,``0}-'></a>
### Times\`\`1(count,function) `method`

##### Summary

Gets a set number of types

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of times |
| function | [System.Func{System.Int32,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Int32,``0}') | Function to use |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of object |

<a name='M-Faker-Extensions-NumberExtensions-To-System-Int32,System-Int32-'></a>
### To(from,to) `method`

##### Summary

Method from one number to another

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') list

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | From [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |
| to | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | To [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |

<a name='T-Faker-Person'></a>
## Person `type`

##### Namespace

Faker

##### Summary

Static person class

<a name='M-Faker-Person-Ssn'></a>
### Ssn() `method`

##### Summary

Gets a random SSN

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='T-Faker-Phone'></a>
## Phone `type`

##### Namespace

Faker

##### Summary

Static phone class

<a name='M-Faker-Phone-FormatPhoneNumber'></a>
### FormatPhoneNumber() `method`

##### Summary

Gets a random phone number format

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') of a random format

##### Parameters

This method has no parameters.

<a name='M-Faker-Phone-GetPhoneNumber'></a>
### GetPhoneNumber() `method`

##### Summary

Gets a random phone number

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') of a random phone number

##### Parameters

This method has no parameters.

<a name='M-Faker-Phone-GetShortPhoneNumber'></a>
### GetShortPhoneNumber() `method`

##### Summary

Gets a short phone number

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') of a short phone number

##### Parameters

This method has no parameters.

<a name='T-Faker-Sports'></a>
## Sports `type`

##### Namespace

Faker

##### Summary

Static class for sport generation

<a name='M-Faker-Sports-SportType'></a>
### SportType() `method`

##### Summary

Grab a random sport type

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

This method has no parameters.

<a name='M-Faker-Sports-SportTypes'></a>
### SportTypes() `method`

##### Summary

Gets a list of sport types

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1')

##### Parameters

This method has no parameters.

<a name='M-Faker-Sports-SportTypes-System-Int32-'></a>
### SportTypes(number) `method`

##### Summary

Gets a list of sport types

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of times |

<a name='T-Faker-Extensions-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

Faker.Extensions

##### Summary

Static string extension class

<a name='M-Faker-Extensions-StringExtensions-Bothify-System-String-'></a>
### Bothify(str) `method`

##### Summary

Combines format

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') from specified format

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |

<a name='M-Faker-Extensions-StringExtensions-Letterify-System-String-'></a>
### Letterify(letterString) `method`

##### Summary

Creates a number based on question marks

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') from specified format

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| letterString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Number string |

<a name='M-Faker-Extensions-StringExtensions-Numerify-System-String-'></a>
### Numerify(numberString) `method`

##### Summary

Creates a number based on pound signs

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') from specified format

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Number string |

<a name='M-Faker-Extensions-StringExtensions-Replace-System-String,System-Char,System-Func{System-Char}-'></a>
### Replace(str,item,character) `method`

##### Summary

Method to replace a string with an item

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to use |
| item | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | A [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') |
| character | [System.Func{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Char}') | Function to use |

<a name='M-Faker-Extensions-StringExtensions-To-System-Char,System-Char-'></a>
### To(from,to) `method`

##### Summary

Method to get a list a characters to and from

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') list of characters

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | From [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') |
| to | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | To [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') |

<a name='T-Faker-Time'></a>
## Time `type`

##### Namespace

Faker

##### Summary

Static class for time generation

<a name='T-Faker-User'></a>
## User `type`

##### Namespace

Faker

##### Summary

Static user class

<a name='M-Faker-User-Email'></a>
### Email() `method`

##### Summary

Gets an email address

##### Returns

An email address as a string

##### Parameters

This method has no parameters.

<a name='M-Faker-User-GeneratePassword-System-Int32,System-Int32-'></a>
### GeneratePassword(length,nonAlphaNumericChars) `method`

##### Summary

Generate password method

##### Returns

Password as string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Length to use |
| nonAlphaNumericChars | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of special characters |

<a name='M-Faker-User-Password-System-Int32,System-Int32-'></a>
### Password(length,numberOfSpecialChars) `method`

##### Summary

Gets a random password

##### Returns

String of password

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Length of password |
| numberOfSpecialChars | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of special characters to use |

<a name='M-Faker-User-Password-System-Int32,System-Boolean-'></a>
### Password(length,useSpecialChars) `method`

##### Summary

Gets a random password

##### Returns

Password as string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Length of password |
| useSpecialChars | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Use special characters.  If true, random number of characters |

<a name='M-Faker-User-Password-System-Int32-'></a>
### Password(numberOfSpecialChars) `method`

##### Summary

Gets a random password.  Will create a password 5 - 20 characters

##### Returns

Password as string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numberOfSpecialChars | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of special characters |

<a name='M-Faker-User-Password'></a>
### Password() `method`

##### Summary

Gets a random password
Random length and number of special characters

##### Returns

Password as string

##### Parameters

This method has no parameters.

<a name='M-Faker-User-Username'></a>
### Username() `method`

##### Summary

Gets a random username

##### Returns

A username as a string

##### Parameters

This method has no parameters.

<a name='T-Faker-Utilities'></a>
## Utilities `type`

##### Namespace

Faker

##### Summary

Static utilities class

<a name='M-Faker-Utilities-AlphaNumeric'></a>
### AlphaNumeric() `method`

##### Summary

Gets a random alpha numeric char

##### Returns

A random char

##### Parameters

This method has no parameters.

<a name='M-Faker-Utilities-Character'></a>
### Character() `method`

##### Summary

Gets a random alpha character

##### Returns

Character to use

##### Parameters

This method has no parameters.

<a name='M-Faker-Utilities-Numerify-System-String-'></a>
### Numerify(s) `method`

##### Summary

Method not implemented

##### Returns

String numbered

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to use |

<a name='T-Faker-Vehicle'></a>
## Vehicle `type`

##### Namespace

Faker

##### Summary

Static vehicle class

<a name='T-Faker-XML'></a>
## XML `type`

##### Namespace

Faker

##### Summary

XML class to handle loading data.xml

<a name='F-Faker-XML-doc'></a>
### doc `constants`

##### Summary

XDocument variable

<a name='F-Faker-XML-docLock'></a>
### docLock `constants`

##### Summary

XDocument lock

<a name='P-Faker-XML-Doc'></a>
### Doc `property`

##### Summary

Gets the XDocument to use

<a name='M-Faker-XML-GetListObject-System-Xml-Linq-XName,System-Xml-Linq-XName-'></a>
### GetListObject(topNode,node) `method`

##### Summary

Gets a object for grabbing node attributes

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| topNode | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | Top node name |
| node | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | Node name |

<a name='M-Faker-XML-GetListString-System-Xml-Linq-XName-'></a>
### GetListString(node) `method`

##### Summary

Gets the list of the data

##### Returns

A list of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | Which node to select |

<a name='M-Faker-XML-GetListString-System-Xml-Linq-XName,System-Xml-Linq-XName-'></a>
### GetListString(topNode,node) `method`

##### Summary

Gets the list of the data

##### Returns

A list of strings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| topNode | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | Which top node to select |
| node | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | Which node to select |

<a name='T-Faker-Models-YearAdjustable51'></a>
## YearAdjustable51 `type`

##### Namespace

Faker.Models

##### Summary

Model for loading from the XML file

<a name='P-Faker-Models-YearAdjustable51-Date'></a>
### Date `property`

##### Summary

Date

<a name='P-Faker-Models-YearAdjustable51-Percentage'></a>
### Percentage `property`

##### Summary

Percentage

<a name='T-Faker-Models-YearAdjustable51JSON'></a>
## YearAdjustable51JSON `type`

##### Namespace

Faker.Models

##### Summary

YearAdjustable51JSON

<a name='P-Faker-Models-YearAdjustable51JSON-DataSet'></a>
### DataSet `property`

##### Summary

DataSet
