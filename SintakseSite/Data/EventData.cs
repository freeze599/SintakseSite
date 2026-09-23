using SintakseSite.Models;

namespace SintakseSite.Data;

public static class EventData
{
    public static List<EventViewModel> Events => new()
    {
        new EventViewModel
        {
            Slug = "cesu-pilsetas-svetki-2026",
            Title = "Cēsu pilsētas svētki",
            Date = new DateTime(2026, 7, 18),
            Time = "17:00",

            Description =
                "K-Sils un Sintakses Stupors Cēsu pilsētas svētku programmā.",

            PosterImage =
                "/images/Events/Cesis2026/cesis2026-18-07.png",

            ExternalUrl =
                "https://pasakumi.cesis.lv/pasakums/svetki-cesis-820/",

            ExternalLinkText = "Plašāka informācija",

            GallerySlug = "cesu-pilsetas-svetki-2026"
        },

        new EventViewModel
        {
            Slug = "vienkarsi-sarezgiti-2026",
            Title = "Vienkārši sarežģīti",
            Date = new DateTime(2026, 7, 23),
            Time = "19:30",

            Description =
                "Kultūras telpā RAA norisināsies dzejas vakars, " +
                "iedvesmojoties no šaha spēles un situācijām, " +
                "kas ir vienkārši sarežģītas.",

            PosterImage =
                "/images/Events/RAA23072026/vienkarsi_sarezgiti.jpg",

            ExternalUrl =
                "https://www.instagram.com/raa_riga/",

            ExternalLinkText = "Kultūras telpa RAA",

            Participants =
                "Evelīna Mūrniece, Džonatans Melgalvis, Dainis Deigelis, " +
                "Linda Tīmane, Andris Alps, Laima Ābele, Ilze Kuzmicka, " +
                "Kristīne Jučkoviča un Dita Putniņa.",

            MusicalGuest = "Zoya Zoyroko",

            GallerySlug = "vienkarsi-sarezgiti-2026"
        },
        new EventViewModel
{
    Slug = "vel-apmacies-2026",

    Title = "Grāmatas \"vēl apmācies\" atvēršanas svētki",

    Date = new DateTime(2026, 8, 7),

    Time = "19:00",

    Description =
        "Sērijā \"Orbītas bibliotēka\" iznācis Andra Alpa dzejas krājums \"vēl apmācies\". " +
        "Veldzes pagrabos paredzēti autora lasījumi, ko papildinās mākslinieka Artūra Puntes " +
        "pilsētas skaņu kompozīcijas un Vārnas kokles spēle. Vakara gaitā dosimies uz " +
        "netālajām RAA telpām, kur norisināsies pasākuma otrā daļa – krājuma redaktora " +
        "Ivara Šteinberga, Orbītas un Andra Alpa uzrunas. Aptuveni plkst. 20.30 paredzēti " +
        "dzejas grupas \"Sintakses Stupors\" biedru un draugu lasījumi.",

    PosterImage = "/images/Events/VelApmacies2026/Aalps.jpg",

    ExternalUrl = "https://www.facebook.com/events/2211939899628958/",

    ExternalLinkText = "Facebook pasākums",

    Participants =
        "Valters Liberts, Pauls Kauķis, Laima Ābele, Meldra Ķemere, " +
        "Lauris Bērziņš, Dainis Deigelis, Kristīne Jučkoviča un citi.",

    MusicalGuest = "Artūrs Punte (pilsētas skaņu kompozīcijas) un Vārna (kokles spēle)",

    GallerySlug = "vel-apmacies-2026"
},
        new EventViewModel
{
    Slug = "sintakses-stupors-kalejos-2026",

    Title = "Sintakses Stupors – Kalējos 2026",

    Date = new DateTime(2026, 6, 6),

    Time = "",

    Description =
        "Dzejas grupas \"Sintakses Stupors\" pasākums Kalējos.",

    PosterImage =
        "/images/Gallery/Kalejos2026/Kalejos1.jpg",

    ExternalUrl = null,

    Participants = null,

    MusicalGuest = null,

    GallerySlug = "sintakses-stupors-kalejos-2026"
},
        new EventViewModel
{
    Slug = "dzejas-nakts-pargajiens-2026",

    Title = "Sintakses Stupors Dzejas nakts pārgājienā",

    Date = new DateTime(2026, 8, 29),

    Time = "10:20",

    Description =
        "No 29. līdz 30. augustam norisināsies Dzejas nakts pārgājiens, " +
        "kas sāksies pie Inčukalna stacijas un turpināsies dažādās Inčukalna, " +
        "Murjāņu, Krimuldas un Siguldas vietās. Programmā paredzēti dzejas lasījumi, " +
        "performances, Baltijas dzejas slams, muzikāli priekšnesumi un brīvais mikrofons. " +
        "Plkst. 15.20 Murjāņos ar 25 minūšu dzejas performanci uzstāsies grupa " +
        "\"Sintakses Stupors\".",

    PosterImage =
        "/images/Events/DzejasPargajiens2026/PargajiensCover.jpg",

    ExternalUrl =   "https://www.facebook.com/events/2301626657038997/?acontext=%7B%22event_action_history%22%3A[%7B%22mechanism%22%3A%22search_results%22%2C%22surface%22%3A%22search%22%7D]%2C%22ref_notif_type%22%3Anull%7D",

    ExternalLinkText = "Plašāka informācija",

    Participants =
        "Arnolds Ščuckis, Alesya Ščucka, Laima Ābele, Andris Alps, Kristīne Jučkoviča, Ilze Kuzmicka, Evelīna Mūrniece, Elza Dobičina",

    MusicalGuest = null,

    Organizer = "",

    GallerySlug = "dzejas-nakts-pargajiens-2026"
},
  new EventViewModel
{
    Slug = "pieturzimes-tumsa-2026",

    Summary = "Poētisks gājiens pamestas rūpnīcas tuneļos. Septiņas dzejas un mākslas stacijas sveču un kabatas lukturīšu gaismā.",
    LocationName = "Salamandras iela 1, Jugla, Rīga",
    PriceText = "7,50 €",
    DurationMinutes = 90, // Approximate duration from the event description.

    Title = "Pieturzīmes tumsā",

    Date = new DateTime(2026, 10, 2),

    Time = "19:00",

    Description =
        "2. oktobrī plkst. 19:00 Salamandras ielā 1, Juglā, notiks poētisks gājiens pamestas rūpnīcas tuneļos.\r\n\r\n" +
        "Pasākuma programmā septiņas dzejas un mākslas stacijas, starp kurām kopīgi maldīsimies tuneļu pustumsā, " +
        "izvairoties no strupceļiem un uzglūnošajām maldugunīm, kamēr ceļu mums izgaismos sveces un kabatas lukturīši.\r\n\r\n" +
        "Piedalīsies dzejnieki un rakstnieki Džena Andersone, Dainis Deigelis, Andris Alps, Liesma Kuzmicka, " +
        "Arnolds Ščuckis, Laima Ābele, kā arī mākslinieces Anete Grīnberga un Olīvija Zeta Survillo.\r\n\r\n" +
        "Ilgums: aptuveni pusotra stunda.\r\n\r\n" +
        "Ieejas maksa: 7,50 eiro. Biļetes iegādājamas pie ieejas vai iepriekšpārdošanā " +
        "(saite tiks publicēta).\r\n\r\n" +
        "Pasākums notiks rūpnīcas teritorijā, tāpēc, ja rodas grūtības ar norises vietas atrašanu, " +
        "lūgums sazināties ar Veroniku pa tālruni 26487587.\r\n\r\n" +
        "Vietu skaits ierobežots, tāpēc ieteicams biļetes iegādāties iepriekš.",

    PosterImage = "/images/Events/Tuneli2026/tuneli.jpg",

    LocationUrl = "https://maps.app.goo.gl/ft6Qnb2jtmRVsMnz7",

    ExternalUrl = "https://www.facebook.com/events/1595627942034770",

    ExternalLinkText = "Facebook pasākums",

    Participants =
        "Džena Andersone, Dainis Deigelis, Andris Alps, Liesma Kuzmicka, " +
        "Arnolds Ščuckis, Laima Ābele, Anete Grīnberga un Olīvija Zeta Survillo.",

    MusicalGuest = null,

    GallerySlug = "pieturzimes-tumsa-2026"
},
        };
    }