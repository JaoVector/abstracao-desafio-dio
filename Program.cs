using Abstracao_Celulares.Classes;


var sam = new Samsung("Android 14", 5, "Galaxy S23");
sam.InsereCelulares(new Samsung("Android 12", 3, "Galaxy Flip"));
sam.InsereCelulares(new Samsung("Android 13", 4, "Galaxy Z"));
sam.InsereCelulares(new Samsung("Android 14", 6, "Galaxy Note"));
sam.InsereCelulares(sam);
sam.ListaCelulares();
sam.GeraArquivoListaDeItems();

var apple = new Apple("IOS 5", 3, "iPhone 5");
apple.InsereCelulares(new Apple("IOS 6", 2, "iPhone 6"));
apple.InsereCelulares(new Apple("IOS 10", 4, "iPhone 11"));
apple.InsereCelulares(new Apple("IOS 11.01", 5, "iPhone 13"));
apple.InsereCelulares(apple);
apple.ListaCelulares();
apple.GeraArquivoListaDeItems();

var xiaomi = new Xiaomi("Android 12.02", 3, "Mi 5");
xiaomi.InsereCelulares(new Xiaomi("Android 13.02", 4, "Mi 7"));
xiaomi.InsereCelulares(new Xiaomi("Android 13.02", 5, "Mi 9"));
xiaomi.InsereCelulares(new Xiaomi("Android 14.02", 6, "Mi 11"));
xiaomi.InsereCelulares(xiaomi);
xiaomi.ListaCelulares();
xiaomi.GeraArquivoListaDeItems();