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
                ObjectPosition = "center 30%",
                Description = "Andris Alps (1988) ir dzejnieks un prozaiķis. Absolvējis Literāro akadēmiju, publicējies daudzos Latvijas literatūras medijos – tostarp žurnālos \"Domuzīme\", \"Strāva\", \"Jaunā Gaita\" un \"Kultūrzīmes\", kā arī tiešsaistes medijā \"Punctum\". Atsevišķi viņa teksti tulkoti angļu un ukraiņu valodā. Aktīvi piedalās dzejas lasījumos, kā arī pats tos organizē – Alps ir viens no dzejas grupas \"Sintakses Stupors\" dibinātājiem un vadītājiem. 2026. gadā izdevniecībā \"Orbīta\" iznācis viņa debijas krājums \"vēl apmācies\". "
            },
            new()
            {
                Name = "Arnolds Ščuckis",
                Image = "Arnolds.jpg",
                Categories = "Dzeja",
                ObjectPosition = "center 30%",
                Description = "Literārās akadēmijas absolvents. Dzeja publicēta žurnālos \"Domuzīme\" un \"Jaunā Gaita\", kā arī literārajos izdevumos \"Kultūrzīmes\" un \"Konteksts\". Savos tekstos apvieno ikdienas novērojumus, sirreālas metaforas un eksistenciālas tēmas, veidojot asociācijām bagātu un atpazīstamu rokrakstu. Piedalījies dzejas lasījumos un citos literāros pasākumos, meklējot arvien jaunus veidus, kā dzejai piešķirt balsi un klātbūtni."
            },
            new()
            {
                Name = "Daina Šteinerte",
                Image = "DainaSt.jpg",
                Categories = "Dzeja · horeogrāfija",
                ObjectPosition = "center 35%",
                Description = "Daina Šteinerte ir audiovizuālā un starpdisciplinārā māksliniece, dzejniece un scenogrāfe. Viņa ieguvusi maģistra grādu scenogrāfijā Latvijas Mākslas akadēmijā (2019), bet pirms tam absolvējusi LMA metāla dizaina/rotu programmu. Viņas radošajā darbībā savienojas scenogrāfija, performance, kustība, eksperimentālā animācija, gaisma, telpa un skaņa."
            },
            new()
            {
                Name = "Dainis Deigelis",
                Image = "DainisD.jpg",
                Categories = "Dzeja · atdzeja · proza",
                ObjectPosition = "center 35%",
                Description = "(1983) – dzejnieks un atdzejotājs. Dzeju latviešu periodikā publicē kopš 2002. gada, regulāri publicējoties dažādos kultūras un literatūras izdevumos. 2018. gadā izdots debijas dzejoļu krājums Dievs beidz, kas nominēts Latvijas Literatūras gada balvai kategorijā \"Spilgtākā debija\". 2020. gadā iznācis otrais krājums Pilsētā mirstošas saules ēnā, bet 2024. gadā – trešais dzejoļu krājums Izdzīvojušie. Tajā pašā gadā bijis arī viens no grāmatas Dzejas detektīvi līdzautoriem. Pašlaik atrodas jaunu radošo meklējumu ceļā gan literatūrā, gan dzīvē, strādājot pie ceturtā dzejoļu krājuma, kura iznākšana plānota 2026. gadā."
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
                Name = "Grejs",
                Image = "Grejs.jpg",
                Categories = "Slavenība",
                ObjectPosition = "center 30%",
                Description = "Wau, wau!"
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
                ObjectPosition = "center 25%",
                Description = "Kaspars Sils — elektroniskās mūzikas mākslinieks, kura radošā darbība saistīta ar Latvijas neatkarīgās un eksperimentālās elektroniskās mūzikas vidi. Darbojies arī ar vārdu K-inspace, bet kā K. Sils pārstāvēts Cēsu elektroniskās mūzikas izlasē. Savā darbībā pievēršas elektroniskajai skaņradei un skaņas mijiedarbībai ar citām mākslas formām. “Sintakses Stupora” performancēs veido skaņas telpu, savienojot elektronisko mūziku ar dzeju un performanci."
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
                ObjectPosition = "center 25%",
                Description = "Raksta dzeju. Absolvējis \"Literārās Akadēmijas\" dzejas meistardarbnīcas Katrīnas Rudzītes (2023) un Ivara Šteinberga (2024) vadībā. Kopš 2022. gada ikgadu piedalās dzejas lasījumos \"Dzejas dienu\" ietvaros un publicējas literatūras žurnālos. Dzejā ir svarīga skaņa un ritms; otrais skaņu dzejnieks Latvijā.\r\n"
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