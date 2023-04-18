using shop;

Product oggettoMaglia = new Product("Maglia blu", 0123456, "Prodotto tessuto al 100% da cotone", 29.99f, 22);

Console.WriteLine(oggettoMaglia.nameProduct());

Console.WriteLine(oggettoMaglia.codeProduct());

Console.WriteLine(oggettoMaglia.descriptionProduct());

Console.WriteLine("Il prezzo del prodotto è di: " + oggettoMaglia.priceProduct());

Console.WriteLine("L'IVA è del " + oggettoMaglia.IVAProduct() + "%");