using SintakseSite.Models;

namespace SintakseSite.Data;

public static class GalleryData
{
    public static List<GalleryViewModel> Galleries => new()
    {
        new GalleryViewModel
        {
            Slug = "cesu-pilsetas-svetki-2026",
            Title = "Cēsu pilsētas svētki",
            Description = "Sintakses Stupora uzstāšanās Cēsu pilsētas svētkos.",
            Date = new DateTime(2026,7,18),

            CoverImage="/images/Gallery/Cesis2026/CesisCover.jpg",

            Images = new()
            {
                "/images/Gallery/Cesis2026/Cesis1.jpg",
                "/images/Gallery/Cesis2026/Cesis2.jpg",
                "/images/Gallery/Cesis2026/Cesis3.jpg",
                "/images/Gallery/Cesis2026/Cesis4.jpg",
                "/images/Gallery/Cesis2026/Cesis5.jpg",
                "/images/Gallery/Cesis2026/Cesis6.jpg",
                "/images/Gallery/Cesis2026/Cesis7.jpg"
            }
        },
        new GalleryViewModel
        {
            Slug = "vienkarsi-sarezgiti-2026",
            Title = "Vienkārši sarežģīti",
            Description = "Sintakses Stupora uzstāšanās RAA mākslas centrā, Veldzes kvartālā.",
            Date = new DateTime(2026,7,23),

            CoverImage="/images/Events/Vnksarezgiti2026/VnksarezgitiMain.jpg",

            Images = new()
            {
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti1.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti2.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti3.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti4.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti5.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti6.jpg",
                "/images/Events/Vnksarezgiti2026/Vnksarezgiti7.jpg",
                "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti8.jpg",
                 "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti9.jpg",
                  "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti10.jpg",
                   "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti11.jpg",
                    "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti12.jpg",
                     "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti13.jpg",
                      "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti14.jpg",
                       "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti15.jpg",
                        "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti16.jpg",
                         "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti17.jpg",
                          "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti18.jpg",
                           "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti19.jpg",
                            "/images/Gallery/Vnksarezgiti2026/Vnksarezgiti20.jpg"
            }
        },

        new GalleryViewModel
{
    Slug = "sintakses-stupors-kalejos-2026",

    Title = "Sintakses Stupors Kalējos 2026",

    Description =
        "Dzejas grupas \"Sintakses Stupors\" pasākums Kalējos 2026. gada 6. jūnijā.",

    Date = new DateTime(2026, 6, 6),

    CoverImage =
        "/images/Gallery/StuporsKaleji2026/KalejiCover.jpg",

    Images = new()
    {
        "/images/Gallery/StuporsKaleji2026/Kaleji1.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji2.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji3.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji4.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji5.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji6.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji7.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji8.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji9.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji10.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji11.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji12.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji13.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji14.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji15.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji16.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji17.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji18.jpg",
        "/images/Gallery/StuporsKaleji2026/Kaleji19.jpg",
      
          "/images/Gallery/StuporsKaleji2026/Kaleji21.jpg",
           "/images/Gallery/StuporsKaleji2026/Kaleji22.jpg",
            "/images/Gallery/StuporsKaleji2026/Kaleji23.jpg",
             "/images/Gallery/StuporsKaleji2026/Kaleji24.jpg",
              "/images/Gallery/StuporsKaleji2026/Kaleji25.jpg",
               "/images/Gallery/StuporsKaleji2026/Kaleji26.jpg",
                "/images/Gallery/StuporsKaleji2026/Kaleji27.jpg",
                 "/images/Gallery/StuporsKaleji2026/Kaleji28.jpg",



    }
},

    };
}