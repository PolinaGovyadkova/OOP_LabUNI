﻿using System.Collections.Generic;

namespace String
{
    /// <summary>
    /// Date
    /// </summary>
    public class Dictionary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dictionary"/> class.
        /// </summary>
        public Dictionary()
        {
        }

        /// <summary>
        /// Countrieses with codes.
        /// </summary>
        /// <returns>Dictionary with countries and codes</returns>
        public Dictionary<string, string> CountriesWithCodes()
        {
            Dictionary<string, string> countries_with_codes = new Dictionary<string, string>()
            {
                ["+43"] = "аustria",
                ["+61"] = "australia",
                ["+54"] = "argentina",
                ["+93"] = "afghanistan",
                ["+32"] = "belgium",
                ["+55"] = "brazil",
                ["+379"] = "vatican",
                ["+44"] = "united_kingdom",
                ["+36"] = "hungary",
                ["+58"] = "venezuela",
                ["+84"] = "vietnam",
                ["+49"] = "germany",
                ["+30"] = "greece",
                ["+45"] = "denmark",
                ["+20"] = "egypt",
                ["+91"] = "india",
                ["+98"] = "iran",
                ["+34"] = "spain",
                ["+39"] = "italy",
                ["+7172"] = "kazakhstan",
                ["+86"] = "china",
                ["+57"] = "colombia",
                ["+53"] = "cuba",
                ["+994"] = "azerbaijan",
                ["+355"] = "albania",
                ["+213"] = "algeria",
                ["+244"] = "angola",
                ["+376"] = "andorra",
                ["+374"] = "armenia",
                ["+880"] = "bangladesh",
                ["+591"] = "bolivia",
                ["+973"] = "bahrain",
                ["+375"] = "belarus",
                ["+501"] = "belize",
                ["+32"] = "belgium",
                ["+229"] = "benin",
                ["+359"] = "bulgaria",
                ["+387"] = "bosnia_and_herzegovina",
                ["+267"] = "botswana",
                ["+55"] = "brazil",
                ["+673"] = "brunei",
                ["+226"] = "burkina_faso",
                ["+257"] = "burundi",
                ["+975"] = "bhutan",
                ["+678"] = "vanuatu",
                ["+670"] = "east_timor",
                ["+241"] = "gabon",
                ["+509"] = "haiti",
                ["+592"] = "guyana",
                ["+220"] = "gambia",
                ["+233"] = "ghana",
                ["+502"] = "guatemala",
                ["+224"] = "guinea",
                ["+245"] = "guinea_bissau",
                ["+504"] = "honduras",
                ["+995"] = "georgia",
                ["+253"] = "djibouti",
                ["+260"] = "zambia",
                ["+263"] = "zimbabwe",
                ["+972"] = "israel",
                ["+962"] = "jordan",
                ["+964"] = "iraq",
                ["+353"] = "ireland",
                ["+354"] = "iceland",
                ["+967"] = "yemen",
                ["+238"] = "cape_verde",
                ["+855"] = "cambodia",
                ["+237"] = "cameroon",
                ["+974"] = "qatar",
                ["+254"] = "kenya",
                ["+357"] = "cyprus",
                ["+996"] = "kyrgyzstan",
                ["+686"] = "kiribati",
                ["+269"] = "comoros",
                ["+243"] = "congo_democratic_republic",
                ["+242"] = "congo_republic",
                ["+506"] = "costa_rica",
                ["+225"] = "cote_divoire",
                ["+965"] = "kuwait",
                ["+856"] = "laos",
                ["+371"] = "latvia",
                ["+266"] = "lesotho",
                ["+231"] = "liberia",
                ["+961"] = "lebanon",
                ["+218"] = "libya",
                ["+370"] = "lithuania",
                ["+423"] = "liechtenstein",
                ["+352"] = "luxembourg",
                ["+1268"] = "antigua_and_barbuda",
                ["+1242"] = "bahamas",
                ["+1246"] = "barbados",
                ["+1767"] = "dominica",
                ["+1809"] = "dominican_republic",
                ["+1"] = "north_america",
                ["+230"] = "mauritius",
                ["+222"] = "mauritania",
                ["+261"] = "madagascar",
                ["+389"] = "macedonia",
                ["+265"] = "malawi",
                ["+60"] = "malaysia",
                ["+223"] = "mali",
                ["+960"] = "maldives",
                ["+356"] = "malta",
                ["+212"] = "morocco",
                ["+692"] = "marshall_islands",
                ["+52"] = "mexico",
                ["+259"] = "mozambique",
                ["+373"] = "moldova",
                ["+377"] = "monaco",
                ["+976"] = "mongolia",
                ["+95"] = "myanmar",
                ["+264"] = "namibia",
                ["+674"] = "nauru",
                ["+977"] = "nepal",
                ["+227"] = "niger",
                ["+234"] = "nigeria",
                ["+31"] = "netherlands",
                ["+505"] = "nicaragua",
                ["+64"] = "new_zealand",
                ["+47"] = "norway",
                ["+971"] = "united_arab_emirates",
                ["+968"] = "oman",
                ["+92"] = "pakistan",
                ["+680"] = "palau",
                ["+507"] = "panama",
                ["+675"] = "papua_new_guinea",
                ["+595"] = "paraguay",
                ["+51"] = "peru",
                ["+48"] = "poland",
                ["+351"] = "portugal",
                ["+7"] = "russia",
                ["+250"] = "rwanda",
                ["+40"] = "romania",
                ["+503"] = "el_salvador",
                ["+685"] = "samoa",
                ["+378"] = "san_marino",
                ["+239"] = "sao_tome_and_principe",
                ["+966"] = "saudi_arabia",
                ["+268"] = "swaziland",
                ["+850"] = "north_korea",
                ["+221"] = "senegal",
                ["+1784"] = "saint_vincent_and_the_grenadines",
                ["+1869"] = "saint_kitts_and_nevis",
                ["+1758"] = "saint_lucia",
                ["+381"] = "serbia",
                ["+65"] = "singapore",
                ["+963"] = "syria",
                ["+421"] = "slovakia",
                ["+986"] = "slovenia",
                ["+677"] = "solomon_islands",
                ["+252"] = "somalia",
                ["+249"] = "sudan",
                ["+597"] = "suriname",
                ["+232"] = "sierra_leone",
                ["+992"] = "tajikistan",
                ["+66"] = "thailand",
                ["+255"] = "tanzania",
                ["+228"] = "togo",
                ["+676"] = "tonga",
                ["+1868"] = "trinidad_and_tobago",
                ["+688"] = "tuvalu",
                ["+216"] = "tunisia",
                ["+993"] = "turkmenistan",
                ["+90"] = "turkey",
                ["+256"] = "uganda",
                ["+998"] = "uzbekistan",
                ["+380"] = "ukraine",
                ["+598"] = "uruguay",
                ["+691"] = "federated_states_of_micronesia",
                ["+679"] = "fiji",
                ["+63"] = "philippines",
                ["+358"] = "finland",
                ["+33"] = "france",
                ["+385"] = "croatia",
                ["+236"] = "central_african_republic",
                ["+235"] = "chad",
                ["+381"] = "montenegro",
                ["+420"] = "czech_republic",
                ["+56"] = "chile",
                ["+41"] = "switzerland",
                ["+46"] = "sweden",
                ["+94"] = "sri_lanka",
                ["+593"] = "ecuador",
                ["+240"] = "equatorial_guinea",
                ["+291"] = "eritrea",
                ["+372"] = "estonia",
                ["+251"] = "ethiopia",
                ["+82"] = "south_korea",
                ["+27"] = "south_africa",
                ["+1876"] = "jamaica",
                ["+81"] = "japan",
                ["+1604"] = "british_columbia, CA",
                ["+1403"] = "alberta, CA",
                ["+1306"] = "saskatchewan, CA",
                ["+1204"] = "manitoba, CA",
                ["+1807"] = "ontario, CA",
                ["+1705"] = "ontario, CA",
                ["+1819"] = "Quebec, CA",
                ["+1418"] = "Quebec, CA",
                ["+1506"] = "new_brunswick, CA",
                ["+1902"] = "prince_edward_island, nova_scotia, CA",
                ["+1709"] = "newfoundland, CA"
            };
            return countries_with_codes;
        }
    }
}