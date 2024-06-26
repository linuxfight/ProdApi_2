using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdApi_2.Models;

namespace ProdApi_2.Database;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasData(
            new() { Id = 1, Name = "Afghanistan", Alpha2 = "AF", Alpha3 = "AFG", Region = "Asia" },
            new() { Id = 2, Name = "Åland Islands", Alpha2 = "AX", Alpha3 = "ALA", Region = "Europe" },
            new() { Id = 3, Name = "Albania", Alpha2 = "AL", Alpha3 = "ALB", Region = "Europe" },
            new() { Id = 4, Name = "Algeria", Alpha2 = "DZ", Alpha3 = "DZA", Region = "Africa" },
            new() { Id = 5, Name = "American Samoa", Alpha2 = "AS", Alpha3 = "ASM", Region = "Oceania" },
            new() { Id = 6, Name = "Andorra", Alpha2 = "AD", Alpha3 = "AND", Region = "Europe" },
            new() { Id = 7, Name = "Angola", Alpha2 = "AO", Alpha3 = "AGO", Region = "Africa" },
            new() { Id = 8, Name = "Anguilla", Alpha2 = "AI", Alpha3 = "AIA", Region = "Americas" },
            //new() { Id = 9, Name = "Antarctica", Alpha2 = "AQ", Alpha3 = "ATA", Region = "" },
            new() { Id = 9, Name = "Byteland PROD", Alpha2 = "YY", Alpha3 = "YYY", Region = "Europe" },
            new() { Id = 10, Name = "Antigua and Barbuda", Alpha2 = "AG", Alpha3 = "ATG", Region = "Americas" },
            new() { Id = 11, Name = "Argentina", Alpha2 = "AR", Alpha3 = "ARG", Region = "Americas" },
            new() { Id = 12, Name = "Armenia", Alpha2 = "AM", Alpha3 = "ARM", Region = "Asia" },
            new() { Id = 13, Name = "Aruba", Alpha2 = "AW", Alpha3 = "ABW", Region = "Americas" },
            new() { Id = 14, Name = "Australia", Alpha2 = "AU", Alpha3 = "AUS", Region = "Oceania" },
            new() { Id = 15, Name = "Austria", Alpha2 = "AT", Alpha3 = "AUT", Region = "Europe" },
            new() { Id = 16, Name = "Azerbaijan", Alpha2 = "AZ", Alpha3 = "AZE", Region = "Asia" },
            new() { Id = 17, Name = "Bahamas", Alpha2 = "BS", Alpha3 = "BHS", Region = "Americas" },
            new() { Id = 18, Name = "Bahrain", Alpha2 = "BH", Alpha3 = "BHR", Region = "Asia" },
            new() { Id = 19, Name = "Bangladesh", Alpha2 = "BD", Alpha3 = "BGD", Region = "Asia" },
            new() { Id = 20, Name = "Barbados", Alpha2 = "BB", Alpha3 = "BRB", Region = "Americas" },
            new() { Id = 21, Name = "Belarus", Alpha2 = "BY", Alpha3 = "BLR", Region = "Europe" },
            new() { Id = 22, Name = "Belgium", Alpha2 = "BE", Alpha3 = "BEL", Region = "Europe" },
            new() { Id = 23, Name = "Belize", Alpha2 = "BZ", Alpha3 = "BLZ", Region = "Americas" },
            new() { Id = 24, Name = "Benin", Alpha2 = "BJ", Alpha3 = "BEN", Region = "Africa" },
            new() { Id = 25, Name = "Bermuda", Alpha2 = "BM", Alpha3 = "BMU", Region = "Americas" },
            new() { Id = 26, Name = "Bhutan", Alpha2 = "BT", Alpha3 = "BTN", Region = "Asia" },
            new() { Id = 27, Name = "Bolivia (Plurinational State of)", Alpha2 = "BO", Alpha3 = "BOL", Region = "Americas" },
            new() { Id = 28, Name = "Bonaire, Sint Eustatius and Saba", Alpha2 = "BQ", Alpha3 = "BES", Region = "Americas" },
            new() { Id = 29, Name = "Bosnia and Herzegovina", Alpha2 = "BA", Alpha3 = "BIH", Region = "Europe" },
            new() { Id = 30, Name = "Botswana", Alpha2 = "BW", Alpha3 = "BWA", Region = "Africa" },
            new() { Id = 31, Name = "Bouvet Island", Alpha2 = "BV", Alpha3 = "BVT", Region = "Americas" },
            new() { Id = 32, Name = "Brazil", Alpha2 = "BR", Alpha3 = "BRA", Region = "Americas" },
            new() { Id = 33, Name = "British Indian Ocean Territory", Alpha2 = "IO", Alpha3 = "IOT", Region = "Africa" },
            new() { Id = 34, Name = "Brunei Darussalam", Alpha2 = "BN", Alpha3 = "BRN", Region = "Asia" },
            new() { Id = 35, Name = "Bulgaria", Alpha2 = "BG", Alpha3 = "BGR", Region = "Europe" },
            new() { Id = 36, Name = "Burkina Faso", Alpha2 = "BF", Alpha3 = "BFA", Region = "Africa" },
            new() { Id = 37, Name = "Burundi", Alpha2 = "BI", Alpha3 = "BDI", Region = "Africa" },
            new() { Id = 38, Name = "Cabo Verde", Alpha2 = "CV", Alpha3 = "CPV", Region = "Africa" },
            new() { Id = 39, Name = "Cambodia", Alpha2 = "KH", Alpha3 = "KHM", Region = "Asia" },
            new() { Id = 40, Name = "Cameroon", Alpha2 = "CM", Alpha3 = "CMR", Region = "Africa" },
            new() { Id = 41, Name = "Canada", Alpha2 = "CA", Alpha3 = "CAN", Region = "Americas" },
            new() { Id = 42, Name = "Cayman Islands", Alpha2 = "KY", Alpha3 = "CYM", Region = "Americas" },
            new() { Id = 43, Name = "Central African Republic", Alpha2 = "CF", Alpha3 = "CAF", Region = "Africa" },
            new() { Id = 44, Name = "Chad", Alpha2 = "TD", Alpha3 = "TCD", Region = "Africa" },
            new() { Id = 45, Name = "Chile", Alpha2 = "CL", Alpha3 = "CHL", Region = "Americas" },
            new() { Id = 46, Name = "China", Alpha2 = "CN", Alpha3 = "CHN", Region = "Asia" },
            new() { Id = 47, Name = "Christmas Island", Alpha2 = "CX", Alpha3 = "CXR", Region = "Oceania" },
            new() { Id = 48, Name = "Cocos (Keeling) Islands", Alpha2 = "CC", Alpha3 = "CCK", Region = "Oceania" },
            new() { Id = 49, Name = "Colombia", Alpha2 = "CO", Alpha3 = "COL", Region = "Americas" },
            new() { Id = 50, Name = "Comoros", Alpha2 = "KM", Alpha3 = "COM", Region = "Africa" },
            new() { Id = 51, Name = "Congo", Alpha2 = "CG", Alpha3 = "COG", Region = "Africa" },
            new() { Id = 52, Name = "Congo, Democratic Republic of the", Alpha2 = "CD", Alpha3 = "COD", Region = "Africa" },
            new() { Id = 53, Name = "Cook Islands", Alpha2 = "CK", Alpha3 = "COK", Region = "Oceania" },
            new() { Id = 54, Name = "Costa Rica", Alpha2 = "CR", Alpha3 = "CRI", Region = "Americas" },
            new() { Id = 55, Name = "Côte d'Ivoire", Alpha2 = "CI", Alpha3 = "CIV", Region = "Africa" },
            new() { Id = 56, Name = "Croatia", Alpha2 = "HR", Alpha3 = "HRV", Region = "Europe" },
            new() { Id = 57, Name = "Cuba", Alpha2 = "CU", Alpha3 = "CUB", Region = "Americas" },
            new() { Id = 58, Name = "Curaçao", Alpha2 = "CW", Alpha3 = "CUW", Region = "Americas" },
            new() { Id = 59, Name = "Cyprus", Alpha2 = "CY", Alpha3 = "CYP", Region = "Asia" },
            new() { Id = 60, Name = "Czechia", Alpha2 = "CZ", Alpha3 = "CZE", Region = "Europe" },
            new() { Id = 61, Name = "Denmark", Alpha2 = "DK", Alpha3 = "DNK", Region = "Europe" },
            new() { Id = 62, Name = "Djibouti", Alpha2 = "DJ", Alpha3 = "DJI", Region = "Africa" },
            new() { Id = 63, Name = "Dominica", Alpha2 = "DM", Alpha3 = "DMA", Region = "Americas" },
            new() { Id = 64, Name = "Dominican Republic", Alpha2 = "DO", Alpha3 = "DOM", Region = "Americas" },
            new() { Id = 65, Name = "Ecuador", Alpha2 = "EC", Alpha3 = "ECU", Region = "Americas" },
            new() { Id = 66, Name = "Egypt", Alpha2 = "EG", Alpha3 = "EGY", Region = "Africa" },
            new() { Id = 67, Name = "El Salvador", Alpha2 = "SV", Alpha3 = "SLV", Region = "Americas" },
            new() { Id = 68, Name = "Equatorial Guinea", Alpha2 = "GQ", Alpha3 = "GNQ", Region = "Africa" },
            new() { Id = 69, Name = "Eritrea", Alpha2 = "ER", Alpha3 = "ERI", Region = "Africa" },
            new() { Id = 70, Name = "Estonia", Alpha2 = "EE", Alpha3 = "EST", Region = "Europe" },
            new() { Id = 71, Name = "Eswatini", Alpha2 = "SZ", Alpha3 = "SWZ", Region = "Africa" },
            new() { Id = 72, Name = "Ethiopia", Alpha2 = "ET", Alpha3 = "ETH", Region = "Africa" },
            new() { Id = 73, Name = "Falkland Islands (Malvinas)", Alpha2 = "FK", Alpha3 = "FLK", Region = "Americas" },
            new() { Id = 74, Name = "Faroe Islands", Alpha2 = "FO", Alpha3 = "FRO", Region = "Europe" },
            new() { Id = 75, Name = "Fiji", Alpha2 = "FJ", Alpha3 = "FJI", Region = "Oceania" },
            new() { Id = 76, Name = "Finland", Alpha2 = "FI", Alpha3 = "FIN", Region = "Europe" },
            new() { Id = 77, Name = "France", Alpha2 = "FR", Alpha3 = "FRA", Region = "Europe" },
            new() { Id = 78, Name = "French Guiana", Alpha2 = "GF", Alpha3 = "GUF", Region = "Americas" },
            new() { Id = 79, Name = "French Polynesia", Alpha2 = "PF", Alpha3 = "PYF", Region = "Oceania" },
            new() { Id = 80, Name = "French Southern Territories", Alpha2 = "TF", Alpha3 = "ATF", Region = "Africa" },
            new() { Id = 81, Name = "Gabon", Alpha2 = "GA", Alpha3 = "GAB", Region = "Africa" },
            new() { Id = 82, Name = "Gambia", Alpha2 = "GM", Alpha3 = "GMB", Region = "Africa" },
            new() { Id = 83, Name = "Georgia", Alpha2 = "GE", Alpha3 = "GEO", Region = "Asia" },
            new() { Id = 84, Name = "Germany", Alpha2 = "DE", Alpha3 = "DEU", Region = "Europe" },
            new() { Id = 85, Name = "Ghana", Alpha2 = "GH", Alpha3 = "GHA", Region = "Africa" },
            new() { Id = 86, Name = "Gibraltar", Alpha2 = "GI", Alpha3 = "GIB", Region = "Europe" },
            new() { Id = 87, Name = "Greece", Alpha2 = "GR", Alpha3 = "GRC", Region = "Europe" },
            new() { Id = 88, Name = "Greenland", Alpha2 = "GL", Alpha3 = "GRL", Region = "Americas" },
            new() { Id = 89, Name = "Grenada", Alpha2 = "GD", Alpha3 = "GRD", Region = "Americas" },
            new() { Id = 90, Name = "Guadeloupe", Alpha2 = "GP", Alpha3 = "GLP", Region = "Americas" },
            new() { Id = 91, Name = "Guam", Alpha2 = "GU", Alpha3 = "GUM", Region = "Oceania" },
            new() { Id = 92, Name = "Guatemala", Alpha2 = "GT", Alpha3 = "GTM", Region = "Americas" },
            new() { Id = 93, Name = "Guernsey", Alpha2 = "GG", Alpha3 = "GGY", Region = "Europe" },
            new() { Id = 94, Name = "Guinea", Alpha2 = "GN", Alpha3 = "GIN", Region = "Africa" },
            new() { Id = 95, Name = "Guinea-Bissau", Alpha2 = "GW", Alpha3 = "GNB", Region = "Africa" },
            new() { Id = 96, Name = "Guyana", Alpha2 = "GY", Alpha3 = "GUY", Region = "Americas" },
            new() { Id = 97, Name = "Haiti", Alpha2 = "HT", Alpha3 = "HTI", Region = "Americas" },
            new() { Id = 98, Name = "Heard Island and McDonald Islands", Alpha2 = "HM", Alpha3 = "HMD", Region = "Oceania" },
            new() { Id = 99, Name = "Holy See", Alpha2 = "VA", Alpha3 = "VAT", Region = "Europe" },
            new() { Id = 100, Name = "Honduras", Alpha2 = "HN", Alpha3 = "HND", Region = "Americas" },
            new() { Id = 101, Name = "Hong Kong", Alpha2 = "HK", Alpha3 = "HKG", Region = "Asia" },
            new() { Id = 102, Name = "Hungary", Alpha2 = "HU", Alpha3 = "HUN", Region = "Europe" },
            new() { Id = 103, Name = "Iceland", Alpha2 = "IS", Alpha3 = "ISL", Region = "Europe" },
            new() { Id = 104, Name = "India", Alpha2 = "IN", Alpha3 = "IND", Region = "Asia" },
            new() { Id = 105, Name = "Indonesia", Alpha2 = "ID", Alpha3 = "IDN", Region = "Asia" },
            new() { Id = 106, Name = "Iran (Islamic Republic of)", Alpha2 = "IR", Alpha3 = "IRN", Region = "Asia" },
            new() { Id = 107, Name = "Iraq", Alpha2 = "IQ", Alpha3 = "IRQ", Region = "Asia" },
            new() { Id = 108, Name = "Ireland", Alpha2 = "IE", Alpha3 = "IRL", Region = "Europe" },
            new() { Id = 109, Name = "Isle of Man", Alpha2 = "IM", Alpha3 = "IMN", Region = "Europe" },
            new() { Id = 110, Name = "Israel", Alpha2 = "IL", Alpha3 = "ISR", Region = "Asia" },
            new() { Id = 111, Name = "Italy", Alpha2 = "IT", Alpha3 = "ITA", Region = "Europe" },
            new() { Id = 112, Name = "Jamaica", Alpha2 = "JM", Alpha3 = "JAM", Region = "Americas" },
            new() { Id = 113, Name = "Japan", Alpha2 = "JP", Alpha3 = "JPN", Region = "Asia" },
            new() { Id = 114, Name = "Jersey", Alpha2 = "JE", Alpha3 = "JEY", Region = "Europe" },
            new() { Id = 115, Name = "Jordan", Alpha2 = "JO", Alpha3 = "JOR", Region = "Asia" },
            new() { Id = 116, Name = "Kazakhstan", Alpha2 = "KZ", Alpha3 = "KAZ", Region = "Asia" },
            new() { Id = 117, Name = "Kenya", Alpha2 = "KE", Alpha3 = "KEN", Region = "Africa" },
            new() { Id = 118, Name = "Kiribati", Alpha2 = "KI", Alpha3 = "KIR", Region = "Oceania" },
            new() { Id = 119, Name = "Korea (Democratic People's Republic of)", Alpha2 = "KP", Alpha3 = "PRK", Region = "Asia" },
            new() { Id = 120, Name = "Korea, Republic of", Alpha2 = "KR", Alpha3 = "KOR", Region = "Asia" },
            new() { Id = 121, Name = "Kuwait", Alpha2 = "KW", Alpha3 = "KWT", Region = "Asia" },
            new() { Id = 122, Name = "Kyrgyzstan", Alpha2 = "KG", Alpha3 = "KGZ", Region = "Asia" },
            new() { Id = 123, Name = "Lao People's Democratic Republic", Alpha2 = "LA", Alpha3 = "LAO", Region = "Asia" },
            new() { Id = 124, Name = "Latvia", Alpha2 = "LV", Alpha3 = "LVA", Region = "Europe" },
            new() { Id = 125, Name = "Lebanon", Alpha2 = "LB", Alpha3 = "LBN", Region = "Asia" },
            new() { Id = 126, Name = "Lesotho", Alpha2 = "LS", Alpha3 = "LSO", Region = "Africa" },
            new() { Id = 127, Name = "Liberia", Alpha2 = "LR", Alpha3 = "LBR", Region = "Africa" },
            new() { Id = 128, Name = "Libya", Alpha2 = "LY", Alpha3 = "LBY", Region = "Africa" },
            new() { Id = 129, Name = "Liechtenstein", Alpha2 = "LI", Alpha3 = "LIE", Region = "Europe" },
            new() { Id = 130, Name = "Lithuania", Alpha2 = "LT", Alpha3 = "LTU", Region = "Europe" },
            new() { Id = 131, Name = "Luxembourg", Alpha2 = "LU", Alpha3 = "LUX", Region = "Europe" },
            new() { Id = 132, Name = "Macao", Alpha2 = "MO", Alpha3 = "MAC", Region = "Asia" },
            new() { Id = 133, Name = "Madagascar", Alpha2 = "MG", Alpha3 = "MDG", Region = "Africa" },
            new() { Id = 134, Name = "Malawi", Alpha2 = "MW", Alpha3 = "MWI", Region = "Africa" },
            new() { Id = 135, Name = "Malaysia", Alpha2 = "MY", Alpha3 = "MYS", Region = "Asia" },
            new() { Id = 136, Name = "Maldives", Alpha2 = "MV", Alpha3 = "MDV", Region = "Asia" },
            new() { Id = 137, Name = "Mali", Alpha2 = "ML", Alpha3 = "MLI", Region = "Africa" },
            new() { Id = 138, Name = "Malta", Alpha2 = "MT", Alpha3 = "MLT", Region = "Europe" },
            new() { Id = 139, Name = "Marshall Islands", Alpha2 = "MH", Alpha3 = "MHL", Region = "Oceania" },
            new() { Id = 140, Name = "Martinique", Alpha2 = "MQ", Alpha3 = "MTQ", Region = "Americas" },
            new() { Id = 141, Name = "Mauritania", Alpha2 = "MR", Alpha3 = "MRT", Region = "Africa" },
            new() { Id = 142, Name = "Mauritius", Alpha2 = "MU", Alpha3 = "MUS", Region = "Africa" },
            new() { Id = 143, Name = "Mayotte", Alpha2 = "YT", Alpha3 = "MYT", Region = "Africa" },
            new() { Id = 144, Name = "Mexico", Alpha2 = "MX", Alpha3 = "MEX", Region = "Americas" },
            new() { Id = 145, Name = "Micronesia (Federated States of)", Alpha2 = "FM", Alpha3 = "FSM", Region = "Oceania" },
            new() { Id = 146, Name = "Moldova, Republic of", Alpha2 = "MD", Alpha3 = "MDA", Region = "Europe" },
            new() { Id = 147, Name = "Monaco", Alpha2 = "MC", Alpha3 = "MCO", Region = "Europe" },
            new() { Id = 148, Name = "Mongolia", Alpha2 = "MN", Alpha3 = "MNG", Region = "Asia" },
            new() { Id = 149, Name = "Montenegro", Alpha2 = "ME", Alpha3 = "MNE", Region = "Europe" },
            new() { Id = 150, Name = "Montserrat", Alpha2 = "MS", Alpha3 = "MSR", Region = "Americas" },
            new() { Id = 151, Name = "Morocco", Alpha2 = "MA", Alpha3 = "MAR", Region = "Africa" },
            new() { Id = 152, Name = "Mozambique", Alpha2 = "MZ", Alpha3 = "MOZ", Region = "Africa" },
            new() { Id = 153, Name = "Myanmar", Alpha2 = "MM", Alpha3 = "MMR", Region = "Asia" },
            new() { Id = 154, Name = "Namibia", Alpha2 = "NA", Alpha3 = "NAM", Region = "Africa" },
            new() { Id = 155, Name = "Nauru", Alpha2 = "NR", Alpha3 = "NRU", Region = "Oceania" },
            new() { Id = 156, Name = "Nepal", Alpha2 = "NP", Alpha3 = "NPL", Region = "Asia" },
            new() { Id = 157, Name = "Netherlands", Alpha2 = "NL", Alpha3 = "NLD", Region = "Europe" },
            new() { Id = 158, Name = "New Caledonia", Alpha2 = "NC", Alpha3 = "NCL", Region = "Oceania" },
            new() { Id = 159, Name = "New Zealand", Alpha2 = "NZ", Alpha3 = "NZL", Region = "Oceania" },
            new() { Id = 160, Name = "Nicaragua", Alpha2 = "NI", Alpha3 = "NIC", Region = "Americas" },
            new() { Id = 161, Name = "Niger", Alpha2 = "NE", Alpha3 = "NER", Region = "Africa" },
            new() { Id = 162, Name = "Nigeria", Alpha2 = "NG", Alpha3 = "NGA", Region = "Africa" },
            new() { Id = 163, Name = "Niue", Alpha2 = "NU", Alpha3 = "NIU", Region = "Oceania" },
            new() { Id = 164, Name = "Norfolk Island", Alpha2 = "NF", Alpha3 = "NFK", Region = "Oceania" },
            new() { Id = 165, Name = "North Macedonia", Alpha2 = "MK", Alpha3 = "MKD", Region = "Europe" },
            new() { Id = 166, Name = "Northern Mariana Islands", Alpha2 = "MP", Alpha3 = "MNP", Region = "Oceania" },
            new() { Id = 167, Name = "Norway", Alpha2 = "NO", Alpha3 = "NOR", Region = "Europe" },
            new() { Id = 168, Name = "Oman", Alpha2 = "OM", Alpha3 = "OMN", Region = "Asia" },
            new() { Id = 169, Name = "Pakistan", Alpha2 = "PK", Alpha3 = "PAK", Region = "Asia" },
            new() { Id = 170, Name = "Palau", Alpha2 = "PW", Alpha3 = "PLW", Region = "Oceania" },
            new() { Id = 171, Name = "Palestine, State of", Alpha2 = "PS", Alpha3 = "PSE", Region = "Asia" },
            new() { Id = 172, Name = "Panama", Alpha2 = "PA", Alpha3 = "PAN", Region = "Americas" },
            new() { Id = 173, Name = "Papua New Guinea", Alpha2 = "PG", Alpha3 = "PNG", Region = "Oceania" },
            new() { Id = 174, Name = "Paraguay", Alpha2 = "PY", Alpha3 = "PRY", Region = "Americas" },
            new() { Id = 175, Name = "Peru", Alpha2 = "PE", Alpha3 = "PER", Region = "Americas" },
            new() { Id = 176, Name = "Philippines", Alpha2 = "PH", Alpha3 = "PHL", Region = "Asia" },
            new() { Id = 177, Name = "Pitcairn", Alpha2 = "PN", Alpha3 = "PCN", Region = "Oceania" },
            new() { Id = 178, Name = "Poland", Alpha2 = "PL", Alpha3 = "POL", Region = "Europe" },
            new() { Id = 179, Name = "Portugal", Alpha2 = "PT", Alpha3 = "PRT", Region = "Europe" },
            new() { Id = 180, Name = "Puerto Rico", Alpha2 = "PR", Alpha3 = "PRI", Region = "Americas" },
            new() { Id = 181, Name = "Qatar", Alpha2 = "QA", Alpha3 = "QAT", Region = "Asia" },
            new() { Id = 182, Name = "Réunion", Alpha2 = "RE", Alpha3 = "REU", Region = "Africa" },
            new() { Id = 183, Name = "Romania", Alpha2 = "RO", Alpha3 = "ROU", Region = "Europe" },
            new() { Id = 184, Name = "Russian Federation", Alpha2 = "RU", Alpha3 = "RUS", Region = "Europe" },
            new() { Id = 185, Name = "Rwanda", Alpha2 = "RW", Alpha3 = "RWA", Region = "Africa" },
            new() { Id = 186, Name = "Saint Barthélemy", Alpha2 = "BL", Alpha3 = "BLM", Region = "Americas" },
            new() { Id = 187, Name = "Saint Helena, Ascension and Tristan da Cunha", Alpha2 = "SH", Alpha3 = "SHN", Region = "Africa" },
            new() { Id = 188, Name = "Saint Kitts and Nevis", Alpha2 = "KN", Alpha3 = "KNA", Region = "Americas" },
            new() { Id = 189, Name = "Saint Lucia", Alpha2 = "LC", Alpha3 = "LCA", Region = "Americas" },
            new() { Id = 190, Name = "Saint Martin (French part)", Alpha2 = "MF", Alpha3 = "MAF", Region = "Americas" },
            new() { Id = 191, Name = "Saint Pierre and Miquelon", Alpha2 = "PM", Alpha3 = "SPM", Region = "Americas" },
            new() { Id = 192, Name = "Saint Vincent and the Grenadines", Alpha2 = "VC", Alpha3 = "VCT", Region = "Americas" },
            new() { Id = 193, Name = "Samoa", Alpha2 = "WS", Alpha3 = "WSM", Region = "Oceania" },
            new() { Id = 194, Name = "San Marino", Alpha2 = "SM", Alpha3 = "SMR", Region = "Europe" },
            new() { Id = 195, Name = "Sao Tome and Principe", Alpha2 = "ST", Alpha3 = "STP", Region = "Africa" },
            new() { Id = 196, Name = "Saudi Arabia", Alpha2 = "SA", Alpha3 = "SAU", Region = "Asia" },
            new() { Id = 197, Name = "Senegal", Alpha2 = "SN", Alpha3 = "SEN", Region = "Africa" },
            new() { Id = 198, Name = "Serbia", Alpha2 = "RS", Alpha3 = "SRB", Region = "Europe" },
            new() { Id = 199, Name = "Seychelles", Alpha2 = "SC", Alpha3 = "SYC", Region = "Africa" },
            new() { Id = 200, Name = "Sierra Leone", Alpha2 = "SL", Alpha3 = "SLE", Region = "Africa" },
            new() { Id = 201, Name = "Singapore", Alpha2 = "SG", Alpha3 = "SGP", Region = "Asia" },
            new() { Id = 202, Name = "Sint Maarten (Dutch part)", Alpha2 = "SX", Alpha3 = "SXM", Region = "Americas" },
            new() { Id = 203, Name = "Slovakia", Alpha2 = "SK", Alpha3 = "SVK", Region = "Europe" },
            new() { Id = 204, Name = "Slovenia", Alpha2 = "SI", Alpha3 = "SVN", Region = "Europe" },
            new() { Id = 205, Name = "Solomon Islands", Alpha2 = "SB", Alpha3 = "SLB", Region = "Oceania" },
            new() { Id = 206, Name = "Somalia", Alpha2 = "SO", Alpha3 = "SOM", Region = "Africa" },
            new() { Id = 207, Name = "South Africa", Alpha2 = "ZA", Alpha3 = "ZAF", Region = "Africa" },
            new() { Id = 208, Name = "South Georgia and the South Sandwich Islands", Alpha2 = "GS", Alpha3 = "SGS", Region = "Americas" },
            new() { Id = 209, Name = "South Sudan", Alpha2 = "SS", Alpha3 = "SSD", Region = "Africa" },
            new() { Id = 210, Name = "Spain", Alpha2 = "ES", Alpha3 = "ESP", Region = "Europe" },
            new() { Id = 211, Name = "Sri Lanka", Alpha2 = "LK", Alpha3 = "LKA", Region = "Asia" },
            new() { Id = 212, Name = "Sudan", Alpha2 = "SD", Alpha3 = "SDN", Region = "Africa" },
            new() { Id = 213, Name = "Suriname", Alpha2 = "SR", Alpha3 = "SUR", Region = "Americas" },
            new() { Id = 214, Name = "Svalbard and Jan Mayen", Alpha2 = "SJ", Alpha3 = "SJM", Region = "Europe" },
            new() { Id = 215, Name = "Sweden", Alpha2 = "SE", Alpha3 = "SWE", Region = "Europe" },
            new() { Id = 216, Name = "Switzerland", Alpha2 = "CH", Alpha3 = "CHE", Region = "Europe" },
            new() { Id = 217, Name = "Syrian Arab Republic", Alpha2 = "SY", Alpha3 = "SYR", Region = "Asia" },
            new() { Id = 218, Name = "Taiwan, Province of China", Alpha2 = "TW", Alpha3 = "TWN", Region = "Asia" },
            new() { Id = 219, Name = "Tajikistan", Alpha2 = "TJ", Alpha3 = "TJK", Region = "Asia" },
            new() { Id = 220, Name = "Tanzania, United Republic of", Alpha2 = "TZ", Alpha3 = "TZA", Region = "Africa" },
            new() { Id = 221, Name = "Thailand", Alpha2 = "TH", Alpha3 = "THA", Region = "Asia" },
            new() { Id = 222, Name = "Timor-Leste", Alpha2 = "TL", Alpha3 = "TLS", Region = "Asia" },
            new() { Id = 223, Name = "Togo", Alpha2 = "TG", Alpha3 = "TGO", Region = "Africa" },
            new() { Id = 224, Name = "Tokelau", Alpha2 = "TK", Alpha3 = "TKL", Region = "Oceania" },
            new() { Id = 225, Name = "Tonga", Alpha2 = "TO", Alpha3 = "TON", Region = "Oceania" },
            new() { Id = 226, Name = "Trinidad and Tobago", Alpha2 = "TT", Alpha3 = "TTO", Region = "Americas" },
            new() { Id = 227, Name = "Tunisia", Alpha2 = "TN", Alpha3 = "TUN", Region = "Africa" },
            new() { Id = 228, Name = "Turkey", Alpha2 = "TR", Alpha3 = "TUR", Region = "Asia" },
            new() { Id = 229, Name = "Turkmenistan", Alpha2 = "TM", Alpha3 = "TKM", Region = "Asia" },
            new() { Id = 230, Name = "Turks and Caicos Islands", Alpha2 = "TC", Alpha3 = "TCA", Region = "Americas" },
            new() { Id = 231, Name = "Tuvalu", Alpha2 = "TV", Alpha3 = "TUV", Region = "Oceania" },
            new() { Id = 232, Name = "Uganda", Alpha2 = "UG", Alpha3 = "UGA", Region = "Africa" },
            new() { Id = 233, Name = "Ukraine", Alpha2 = "UA", Alpha3 = "UKR", Region = "Europe" },
            new() { Id = 234, Name = "United Arab Emirates", Alpha2 = "AE", Alpha3 = "ARE", Region = "Asia" },
            new() { Id = 235, Name = "United Kingdom of Great Britain and Northern Ireland", Alpha2 = "GB", Alpha3 = "GBR", Region = "Europe" },
            new() { Id = 236, Name = "United States of America", Alpha2 = "US", Alpha3 = "USA", Region = "Americas" },
            new() { Id = 237, Name = "United States Minor Outlying Islands", Alpha2 = "UM", Alpha3 = "UMI", Region = "Oceania" },
            new() { Id = 238, Name = "Uruguay", Alpha2 = "UY", Alpha3 = "URY", Region = "Americas" },
            new() { Id = 239, Name = "Uzbekistan", Alpha2 = "UZ", Alpha3 = "UZB", Region = "Asia" },
            new() { Id = 240, Name = "Vanuatu", Alpha2 = "VU", Alpha3 = "VUT", Region = "Oceania" },
            new() { Id = 241, Name = "Venezuela (Bolivarian Republic of)", Alpha2 = "VE", Alpha3 = "VEN", Region = "Americas" },
            new() { Id = 242, Name = "Viet Nam", Alpha2 = "VN", Alpha3 = "VNM", Region = "Asia" },
            new() { Id = 243, Name = "Virgin Islands (British)", Alpha2 = "VG", Alpha3 = "VGB", Region = "Americas" },
            new() { Id = 244, Name = "Virgin Islands (U.S.)", Alpha2 = "VI", Alpha3 = "VIR", Region = "Americas" },
            new() { Id = 245, Name = "Wallis and Futuna", Alpha2 = "WF", Alpha3 = "WLF", Region = "Oceania" },
            new() { Id = 246, Name = "Western Sahara", Alpha2 = "EH", Alpha3 = "ESH", Region = "Africa" },
            new() { Id = 247, Name = "Yemen", Alpha2 = "YE", Alpha3 = "YEM", Region = "Asia" },
            new() { Id = 248, Name = "Zambia", Alpha2 = "ZM", Alpha3 = "ZMB", Region = "Africa" },
            new() { Id = 249, Name = "Zimbabwe", Alpha2 = "ZW", Alpha3 = "ZWE", Region = "Africa" }
        );
    }
}