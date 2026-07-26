using SintakseSite.Models;
using System.Globalization;

namespace SintakseSite.Data
{
    public static class AuthorData
    {
        public static List<AuthorViewModel> Authors { get; } = new()
        {
            new()
            {
                Name = "Aļesja Loseva",
                Image = "Alesja.jpg",
                Categories = "Dzeja · atdzeja",
                ObjectPosition = "center 25%"
            },
            new()
            {
                Name = "Andris Alps",
                Image = "Alps.jpg",
                Categories = "Dzeja · proza",
                ObjectPosition = "center 30%"
            },
            new()
            {
                Name = "Arnolds Ščuckis",
                Image = "Arnolds.jpg",
                Categories = "Dzeja",
                ObjectPosition = "center 30%"
            },
            new()
            {
                Name = "Daina Šteinerte",
                Image = "DainaSt.jpg",
                Categories = "Dzeja · horeogrāfija",
                ObjectPosition = "center 35%"
            },
            new()
            {
                Name = "Dainis Deigelis",
                Image = "DainisD.jpg",
                Categories = "Dzeja · atdzeja · proza",
                ObjectPosition = "center 35%"
            },
            new()
            {
                Name = "Dita Putniņa",
                Image = "DitaP.jpg",
                Categories = "Dzeja",
                ObjectPosition = "center 30%"
            },
            new()
            {
                Name = "Ilze Kuzmicka",
                Image = "IlzeK.jpg",
                Categories = "Dzeja",
                ObjectPosition = "center 25%",
                Description = "Ir trīs bērnu mamma, dravniece, dabas mīle un paliatīvās aprūpes darbiniece. Viņas ikdiena rit starp bišu stropiem, cilvēku aprūpi un tekstu rindām. Ilzes pasaule ir cieši saistīta ar dabu un cilvēka trauslumu, taču tikpat svarīga viņai ir arī sociālā telpa — viņa ir kvīrs un mazslodzes aktīviste. Tas izpaužas gan balsī, dziedot Rīgas Kvīru korī, gan klātbūtnē piketos un protestos.\r\nRadošajā darbībā viņa raksta dzeju un ir daļa no dzejnieku apvienības \"Sintakses Stupors\". Ilzei ir svarīgi dzeju iznest ārpus lapas robežām, tāpēc viņa veido un piedalās performancēs ar dzejas elementiem un dažādos lasījumos. Viņas dzeja publicēta  \"Avīzes nosaukums\" numuros, \"Vecāku būšana: pirmā gada stāsti\".\r\nSavos tekstos viņa nedistancējas, bet raksta caur tiešo pieredzi: ķermenisko, emocionālo un garīgo. Lai šo valodu slīpētu, Ilze divus gadus mācījusies Latvijas Rakstnieku savienības dzejas meistarklasēs \"Literārajā akadēmijā\" pie Ronalda Brieža, Toma Treiberga un Ivara Šteinberga. Viņa plāno mācības turpināt, uztverot rakstīšanu kā nepārtrauktu pilnveidošanās procesu."
            },
            new()
            {
                Name = "Kaspars Sils",
                Image = "KasparsS.jpg",
                Categories = "Mūzika",
                ObjectPosition = "center 25%"
            },
            new()
            {
                Name = "Katrīna Jēkabsone",
                Image = "KatrinaJ.jpg",
                Categories = "Dzeja",
                ObjectPosition = "center 30%"
            },
            new()
{
    Name = "Kristīne Jučkoviča",
    Image = "KristineJ.jpg",
    Categories = "Dzeja · proza · rakstniecība",
    ObjectPosition = "center 25%",

    Description = """
    Raksta dzeju un prozu, ikdienā ir mācībspēks, strādā veselības aprūpes vadībā, ir pusaudžu mamma, frankofīle, aizrautīga dziedātāja un rožkope.

    Kristīnes literārajā darbībā galvenajā lomā ir sieviete — arhetipiskā un mūsdienu, viņas ikdiena, iekšējā pasaule un novecošanas procesi. Kristīne pašlaik strādā pie dzejas krājuma apkopošanas, jau izdotas divas prozas grāmatas — stāstu krājums “Viņa nāk” un romāns “Nesaki ne jā, ne nē”. Dzejā publicējusies kopkrājumos, tīkla un drukātos literāros žurnālos.

    Kristīne labprāt piedalās lasījumos kopā ar savu dzejas grupu “Sintakses stupors”, kā arī dažādos festivālos un citos kultūras notikumos. Dzejā viņai svarīgs ir ritms, valodas plūdums, tās nianses un intonācija.
    """
},
            new()
            {
                Name = "Laima Ābele",
                Image = "Laima.jpg",
                Categories = "Dzeja",
                ObjectPosition = "center 25%"
            },
             new()
            {
                Name = "Laura Steimāre",
                Image = "LauraS.jpg",
                Categories = "Dzeja",
                ObjectPosition = "center 25%",
                Description = "Brīvdienās – dzejniece, darba dienās – preču komplektētāja. Piedalījusies dzejas slamos un apguvusi dzejas teoriju Literārajā akadēmijā. Publicēta kopkrājumos \"Kā tauriņi\" (2014), \"Manas vasaras stāsts\" (2015), \"Zemteksts\" (2020) un \"Mani apsteidza vējš\". Izdoti arī divi autores dzejoļu krājumi – \"Asni\" (2017) un \"Vibrācijas\" (2024).\r\n\r\nKopš 2005. gada aktīvi iesaistās LGBT kopienas aktivitātēs. Filmējusi, montējusi video un fotografējusi dažādus pasākumus un notikumus."
            },
            new()
            {
                Name = "Meldra Ķemere",
                Image = "MeldraK.jpg",
                Categories = "Dzeja",
                ObjectPosition = "center 25%"
            },
            new()
            {
                Name = "Pauls Kauķis",
                Image = "PaulsK.jpg",
                Categories = "Dzeja",
                ObjectPosition = "center 25%"
            },
            new()
            {
                Name = "Zane Brūvere-Kvēpa",
                Image = "ZaneB.jpg",
                Categories = "Dzeja · Tulkošana · Redakcija",
                ObjectPosition = "center 25%",
                Description = "(1983) – dzejniece, tulkotāja, redaktore. Valkas novada literārās apvienības vadītāja. Raksta dzeju, kā arī vada dzejas meistardarbnīcas bērniem. Bijusi turku valodas pasniedzēja Latvijas Universitātē, projektu vadītāja Nodarbinātības valsts aģentūrā, kā arī sabiedrisko attiecību speciāliste Valkas novada domē un Rakstniecības un mūzikas muzejā, redaktore Dzintaru koncertzālē. Tulkojusi no lietuviešu un turku valodas."
            }

        };
    }
}