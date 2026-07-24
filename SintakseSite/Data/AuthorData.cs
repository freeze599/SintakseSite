using SintakseSite.Models;

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
                ObjectPosition = "center 25%"
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
                Categories = "Dzeja",
                ObjectPosition = "center 25%"
            }
        };
    }
}