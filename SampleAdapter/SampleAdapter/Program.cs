// See https://aka.ms/new-console-template for more information
using SampleAdapter;
using SampleAdapter.Adapter;
using SampleAdapter.HomeCats;
using SampleAdapter.WildCats;

Console.WriteLine("Hello, World!");
IHomeCat vasya = new YardCat();
vasya.Name = "Василий";
PrintCatInfo.CatInfoPrint(vasya);
IHomeCat muska = new PedigreedCat();
muska.Name = "Муся";
PrintCatInfo.CatInfoPrint(muska);

IWildCat tiger = new Tiger();
IHomeCat hometiger = new HomeCatAdapter(tiger);
PrintCatInfo.CatInfoPrint(hometiger);