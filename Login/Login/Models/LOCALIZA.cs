using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class LOCALIZA
    {
        public List<MUNICIPIO_LOCALIZA> municipios { get; set; }

        public LOCALIZA()
        {
            this.municipios = new List<MUNICIPIO_LOCALIZA>();
            municipios.Add(new MUNICIPIO_LOCALIZA(1101, 1, 11, -69.3928397127, -70.041538352, "Región de Tarapacá", "Tarapacá", "Iquique", "Iquique"));
            municipios.Add(new MUNICIPIO_LOCALIZA(1107, 1, 11, -69.3928397127, -70.0109621438, "Región de Tarapacá", "Tarapacá", "Iquique", "Alto Hospicio"));
            municipios.Add(new MUNICIPIO_LOCALIZA(1401, 1, 14, -69.3928397127, -69.5042362991, "Región de Tarapacá", "Tarapacá", "Tamarugal", "Pozo Almonte"));
            municipios.Add(new MUNICIPIO_LOCALIZA(1402, 1, 14, -69.3928397127, -69.5053391192, "Región de Tarapacá", "Tarapacá", "Tamarugal", "Camiña"));
            municipios.Add(new MUNICIPIO_LOCALIZA(1403, 1, 14, -69.3928397127, -68.8442188762, "Región de Tarapacá", "Tarapacá", "Tamarugal", "Colchane"));
            municipios.Add(new MUNICIPIO_LOCALIZA(1404, 1, 14, -69.3928397127, -69.6628965053, "Región de Tarapacá", "Tarapacá", "Tamarugal", "Huara"));
            municipios.Add(new MUNICIPIO_LOCALIZA(1405, 1, 14, -69.3928397127, -68.9122031293, "Región de Tarapacá", "Tarapacá", "Tamarugal", "Pica"));
            municipios.Add(new MUNICIPIO_LOCALIZA(2101, 2, 21, -69.1155677706, -69.4100886557, "Región de Antofagasta", "Antofagasta", "Antofagasta", "Antofagasta"));
            municipios.Add(new MUNICIPIO_LOCALIZA(2102, 2, 21, -69.1155677706, -70.2030457945, "Región de Antofagasta", "Antofagasta", "Antofagasta", "Mejillones"));
            municipios.Add(new MUNICIPIO_LOCALIZA(2103, 2, 21, -69.1155677706, -69.3055670988, "Región de Antofagasta", "Antofagasta", "Antofagasta", "Sierra Gorda"));
            municipios.Add(new MUNICIPIO_LOCALIZA(2104, 2, 21, -69.1155677706, -69.8652040215, "Región de Antofagasta", "Antofagasta", "Antofagasta", "Taltal"));
            municipios.Add(new MUNICIPIO_LOCALIZA(2201, 2, 22, -69.1155677706, -68.6297098246, "Región de Antofagasta", "Antofagasta", "El Loa", "Calama"));
            municipios.Add(new MUNICIPIO_LOCALIZA(2202, 2, 22, -69.1155677706, -68.3132579862, "Región de Antofagasta", "Antofagasta", "El Loa", "Ollagüe"));
            municipios.Add(new MUNICIPIO_LOCALIZA(2203, 2, 22, -69.1155677706, -67.9093983783, "Región de Antofagasta", "Antofagasta", "El Loa", "San Pedro de Atacama"));
            municipios.Add(new MUNICIPIO_LOCALIZA(2301, 2, 23, -69.1155677706, -70.0212244558, "Región de Antofagasta", "Antofagasta", "Tocopilla", "Tocopilla"));
            municipios.Add(new MUNICIPIO_LOCALIZA(2302, 2, 23, -69.1155677706, -69.4670674746, "Región de Antofagasta", "Antofagasta", "Tocopilla", "María Elena"));
            municipios.Add(new MUNICIPIO_LOCALIZA(3101, 3, 31, -69.9023342263, -69.82547165, "Región de Atacama", "Atacama", "Copiapó", "Copiapó"));
            municipios.Add(new MUNICIPIO_LOCALIZA(3102, 3, 31, -69.9023342263, -70.6821335891, "Región de Atacama", "Atacama", "Copiapó", "Caldera"));
            municipios.Add(new MUNICIPIO_LOCALIZA(3103, 3, 31, -69.9023342263, -69.670693015, "Región de Atacama", "Atacama", "Copiapó", "Tierra Amarilla"));
            municipios.Add(new MUNICIPIO_LOCALIZA(3201, 3, 32, -69.9023342263, -70.3379746068, "Región de Atacama", "Atacama", "Chañaral", "Chañaral"));
            municipios.Add(new MUNICIPIO_LOCALIZA(3202, 3, 32, -69.9023342263, -69.1860389258, "Región de Atacama", "Atacama", "Chañaral", "Diego de Almagro"));
            municipios.Add(new MUNICIPIO_LOCALIZA(3301, 3, 33, -69.9023342263, -70.6017299627, "Región de Atacama", "Atacama", "Huasco", "Vallenar"));
            municipios.Add(new MUNICIPIO_LOCALIZA(3302, 3, 33, -69.9023342263, -70.1564228881, "Región de Atacama", "Atacama", "Huasco", "Alto del Carmen"));
            municipios.Add(new MUNICIPIO_LOCALIZA(3303, 3, 33, -69.9023342263, -71.1788201806, "Región de Atacama", "Atacama", "Huasco", "Freirina"));
            municipios.Add(new MUNICIPIO_LOCALIZA(3304, 3, 33, -69.9023342263, -71.0280980766, "Región de Atacama", "Atacama", "Huasco", "Huasco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4101, 4, 41, -70.8585239858, -71.0608208619, "Región de Coquimbo", "Coquimbo", "Elqui", "La Serena"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4102, 4, 41, -70.8585239858, -71.3589871987, "Región de Coquimbo", "Coquimbo", "Elqui", "Coquimbo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4103, 4, 41, -70.8585239858, -71.1006377659, "Región de Coquimbo", "Coquimbo", "Elqui", "Andacollo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4104, 4, 41, -70.8585239858, -70.9025648798, "Región de Coquimbo", "Coquimbo", "Elqui", "La Higuera"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4105, 4, 41, -70.8585239858, -70.3697470219, "Región de Coquimbo", "Coquimbo", "Elqui", "Paiguano"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4106, 4, 41, -70.8585239858, -70.3814578309, "Región de Coquimbo", "Coquimbo", "Elqui", "Vicuña"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4201, 4, 42, -70.8585239858, -70.9705682605, "Región de Coquimbo", "Coquimbo", "Choapa", "Illapel"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4202, 4, 42, -70.8585239858, -71.3943841986, "Región de Coquimbo", "Coquimbo", "Choapa", "Canela"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4203, 4, 42, -70.8585239858, -71.3042545677, "Región de Coquimbo", "Coquimbo", "Choapa", "Los Vilos"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4204, 4, 42, -70.8585239858, -70.6619085753, "Región de Coquimbo", "Coquimbo", "Choapa", "Salamanca"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4301, 4, 43, -70.8585239858, -71.4053054306, "Región de Coquimbo", "Coquimbo", "Limarí", "Ovalle"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4302, 4, 43, -70.8585239858, -70.9657356492, "Región de Coquimbo", "Coquimbo", "Limarí", "Combarbalá"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4303, 4, 43, -70.8585239858, -70.650608689, "Región de Coquimbo", "Coquimbo", "Limarí", "Monte Patria"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4304, 4, 43, -70.8585239858, -71.3326274023, "Región de Coquimbo", "Coquimbo", "Limarí", "Punitaqui"));
            municipios.Add(new MUNICIPIO_LOCALIZA(4305, 4, 43, -70.8585239858, -70.653739198, "Región de Coquimbo", "Coquimbo", "Limarí", "Río Hurtado"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5101, 5, 51, -70.8915740187, -71.7533398553, "Región de Valparaíso", "Valparaíso", "Valparaíso", "Valparaíso"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5102, 5, 51, -70.8915740187, -71.4349790946, "Región de Valparaíso", "Valparaíso", "Valparaíso", "Casablanca"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5103, 5, 51, -70.8915740187, -71.4678670083, "Región de Valparaíso", "Valparaíso", "Valparaíso", "Concón"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5104, 5, 51, -70.8915740187, -79.8701772623, "Región de Valparaíso", "Valparaíso", "Valparaíso", "Juan Fernández"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5105, 5, 51, -70.8915740187, -71.3879230101, "Región de Valparaíso", "Valparaíso", "Valparaíso", "Puchuncaví"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5107, 5, 51, -70.8915740187, -71.4732304592, "Región de Valparaíso", "Valparaíso", "Valparaíso", "Quintero"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5109, 5, 51, -70.8915740187, -71.5154312157, "Región de Valparaíso", "Valparaíso", "Valparaíso", "Viña del Mar"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5201, 5, 52, -70.8915740187, -109.477524207, "Región de Valparaíso", "Valparaíso", "Isla de Pascua", "Isla de Pascua"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5301, 5, 53, -70.8915740187, -70.2435624785, "Región de Valparaíso", "Valparaíso", "Los Andes", "Los Andes"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5302, 5, 53, -70.8915740187, -70.544659459, "Región de Valparaíso", "Valparaíso", "Los Andes", "Calle Larga"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5303, 5, 53, -70.8915740187, -70.7061975531, "Región de Valparaíso", "Valparaíso", "Los Andes", "Rinconada"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5304, 5, 53, -70.8915740187, -70.3477585261, "Región de Valparaíso", "Valparaíso", "Los Andes", "San Esteban"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5401, 5, 54, -70.8915740187, -71.2717016023, "Región de Valparaíso", "Valparaíso", "Petorca", "La Ligua"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5402, 5, 54, -70.8915740187, -70.8235358129, "Región de Valparaíso", "Valparaíso", "Petorca", "Cabildo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5403, 5, 54, -70.8915740187, -71.3803278083, "Región de Valparaíso", "Valparaíso", "Petorca", "Papudo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5404, 5, 54, -70.8915740187, -70.869906028, "Región de Valparaíso", "Valparaíso", "Petorca", "Petorca"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5405, 5, 54, -70.8915740187, -71.3362776202, "Región de Valparaíso", "Valparaíso", "Petorca", "Zapallar"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5501, 5, 55, -70.8915740187, -71.2724210415, "Región de Valparaíso", "Valparaíso", "Quillota", "Quillota"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5502, 5, 55, -70.8915740187, -71.157053149, "Región de Valparaíso", "Valparaíso", "Quillota", "Calera"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5503, 5, 55, -70.8915740187, -71.0811107747, "Región de Valparaíso", "Valparaíso", "Quillota", "Hijuelas"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5504, 5, 55, -70.8915740187, -71.2404787004, "Región de Valparaíso", "Valparaíso", "Quillota", "La Cruz"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5506, 5, 55, -70.8915740187, -71.1761018798, "Región de Valparaíso", "Valparaíso", "Quillota", "Nogales"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5601, 5, 56, -70.8915740187, -71.4869305281, "Región de Valparaíso", "Valparaíso", "San Antonio", "San Antonio"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5602, 5, 56, -70.8915740187, -71.5993956467, "Región de Valparaíso", "Valparaíso", "San Antonio", "Algarrobo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5603, 5, 56, -70.8915740187, -71.4422082117, "Región de Valparaíso", "Valparaíso", "San Antonio", "Cartagena"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5604, 5, 56, -70.8915740187, -71.651188756, "Región de Valparaíso", "Valparaíso", "San Antonio", "El Quisco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5605, 5, 56, -70.8915740187, -71.5806343546, "Región de Valparaíso", "Valparaíso", "San Antonio", "El Tabo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5606, 5, 56, -70.8915740187, -71.6765110141, "Región de Valparaíso", "Valparaíso", "San Antonio", "Santo Domingo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5701, 5, 57, -70.8915740187, -70.7529583568, "Región de Valparaíso", "Valparaíso", "San Felipe", "San Felipe"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5702, 5, 57, -70.8915740187, -70.9446388023, "Región de Valparaíso", "Valparaíso", "San Felipe", "Catemu"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5703, 5, 57, -70.8915740187, -70.9017326371, "Región de Valparaíso", "Valparaíso", "San Felipe", "Llaillay"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5704, 5, 57, -70.8915740187, -70.8283122248, "Región de Valparaíso", "Valparaíso", "San Felipe", "Panquehue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5705, 5, 57, -70.8915740187, -70.5212302349, "Región de Valparaíso", "Valparaíso", "San Felipe", "Putaendo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5706, 5, 57, -70.8915740187, -70.6097026593, "Región de Valparaíso", "Valparaíso", "San Felipe", "Santa María"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5801, 5, 58, -70.8915740187, -71.2540917137, "Región de Valparaíso", "Valparaíso", "Margamarga", "Quilpué"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5802, 5, 58, -70.8915740187, -71.2789117691, "Región de Valparaíso", "Valparaíso", "Margamarga", "Limache"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5803, 5, 58, -70.8915740187, -71.1104338102, "Región de Valparaíso", "Valparaíso", "Margamarga", "Olmué"));
            municipios.Add(new MUNICIPIO_LOCALIZA(5804, 5, 58, -70.8915740187, -71.330163502, "Región de Valparaíso", "Valparaíso", "Margamarga", "Villa Alemana"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6101, 6, 61, -71.0468193683, -70.816747872, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Rancagua"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6102, 6, 61, -71.0468193683, -70.547188352, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Codegua"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6103, 6, 61, -71.0468193683, -70.97110458, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Coinco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6104, 6, 61, -71.0468193683, -71.0775608206, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Coltauco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6105, 6, 61, -71.0468193683, -70.9236348255, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Doñihue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6106, 6, 61, -71.0468193683, -70.7470714577, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Graneros"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6107, 6, 61, -71.0468193683, -71.3327813423, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Las Cabras"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6108, 6, 61, -71.0468193683, -70.319487195, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Machalí"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6109, 6, 61, -71.0468193683, -70.8729170446, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Malloa"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6110, 6, 61, -71.0468193683, -70.5688119247, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Mostazal"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6111, 6, 61, -71.0468193683, -70.8210998259, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Olivar"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6112, 6, 61, -71.0468193683, -71.2218813362, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Peumo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6113, 6, 61, -71.0468193683, -71.339092237, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Pichidegua"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6114, 6, 61, -71.0468193683, -70.9980672834, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Quinta de Tilcoco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6115, 6, 61, -71.0468193683, -70.7189568704, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Rengo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6116, 6, 61, -71.0468193683, -70.6591961618, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "Requínoa"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6117, 6, 61, -71.0468193683, -71.123127305, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cachapoal", "San Vicente"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6201, 6, 62, -71.0468193683, -71.9106902935, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cardenal Caro", "Pichilemu"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6202, 6, 62, -71.0468193683, -71.6025513707, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cardenal Caro", "La Estrella"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6203, 6, 62, -71.0468193683, -71.7330914364, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cardenal Caro", "Litueche"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6204, 6, 62, -71.0468193683, -71.6717648667, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cardenal Caro", "Marchihue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6205, 6, 62, -71.0468193683, -71.8207690244, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cardenal Caro", "Navidad"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6206, 6, 62, -71.0468193683, -71.9115377098, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Cardenal Caro", "Paredones"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6301, 6, 63, -71.0468193683, -70.6032868181, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Colchagua", "San Fernando"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6302, 6, 63, -71.0468193683, -71.3597393619, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Colchagua", "Chépica"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6303, 6, 63, -71.0468193683, -70.9808799529, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Colchagua", "Chimbarongo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6304, 6, 63, -71.0468193683, -71.6488324554, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Colchagua", "Lolol"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6305, 6, 63, -71.0468193683, -71.1919713174, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Colchagua", "Nancagua"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6306, 6, 63, -71.0468193683, -71.3529130902, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Colchagua", "Palmilla"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6307, 6, 63, -71.0468193683, -71.4966804722, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Colchagua", "Peralillo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6308, 6, 63, -71.0468193683, -71.0863094472, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Colchagua", "Placilla"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6309, 6, 63, -71.0468193683, -71.6917721695, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Colchagua", "Pumanque"));
            municipios.Add(new MUNICIPIO_LOCALIZA(6310, 6, 63, -71.0468193683, -71.4019190205, "Región del Libertador General Bernardo O'Higgins", "O'Higgins", "Colchagua", "Santa Cruz"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7101, 7, 71, -71.4463212218, -71.6021975979, "Región del Maule", "Maule", "Talca", "Talca"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7102, 7, 71, -71.4463212218, -72.2757990108, "Región del Maule", "Maule", "Talca", "Constitución"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7103, 7, 71, -71.4463212218, -71.9529801365, "Región del Maule", "Maule", "Talca", "Curepto"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7104, 7, 71, -71.4463212218, -72.284386519, "Región del Maule", "Maule", "Talca", "Empedrado"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7105, 7, 71, -71.4463212218, -71.7120541694, "Región del Maule", "Maule", "Talca", "Maule"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7106, 7, 71, -71.4463212218, -71.3500292078, "Región del Maule", "Maule", "Talca", "Pelarco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7107, 7, 71, -71.4463212218, -71.8161738166, "Región del Maule", "Maule", "Talca", "Pencahue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7108, 7, 71, -71.4463212218, -71.2688621061, "Región del Maule", "Maule", "Talca", "Río Claro"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7109, 7, 71, -71.4463212218, -70.8497817736, "Región del Maule", "Maule", "Talca", "San Clemente"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7110, 7, 71, -71.4463212218, -71.5004743803, "Región del Maule", "Maule", "Talca", "San Rafael"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7201, 7, 72, -71.4463212218, -72.2804905385, "Región del Maule", "Maule", "Cauquenes", "Cauquenes"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7202, 7, 72, -71.4463212218, -72.4850225684, "Región del Maule", "Maule", "Cauquenes", "Chanco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7203, 7, 72, -71.4463212218, -72.6074092657, "Región del Maule", "Maule", "Cauquenes", "Pelluhue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7301, 7, 73, -71.4463212218, -70.8973707757, "Región del Maule", "Maule", "Curicó", "Curicó"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7302, 7, 73, -71.4463212218, -71.7087939486, "Región del Maule", "Maule", "Curicó", "Hualañé"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7303, 7, 73, -71.4463212218, -72.060329116, "Región del Maule", "Maule", "Curicó", "Licantén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7304, 7, 73, -71.4463212218, -70.9109223843, "Región del Maule", "Maule", "Curicó", "Molina"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7305, 7, 73, -71.4463212218, -71.4257655703, "Región del Maule", "Maule", "Curicó", "Rauco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7306, 7, 73, -71.4463212218, -70.712024862, "Región del Maule", "Maule", "Curicó", "Romeral"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7307, 7, 73, -71.4463212218, -71.495698972, "Región del Maule", "Maule", "Curicó", "Sagrada Familia"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7308, 7, 73, -71.4463212218, -71.0218393344, "Región del Maule", "Maule", "Curicó", "Teno"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7309, 7, 73, -71.4463212218, -72.0225310265, "Región del Maule", "Maule", "Curicó", "Vichuquén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7401, 7, 74, -71.4463212218, -71.3325671389, "Región del Maule", "Maule", "Linares", "Linares"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7402, 7, 74, -71.4463212218, -70.9801742421, "Región del Maule", "Maule", "Linares", "Colbún"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7403, 7, 74, -71.4463212218, -71.4419609374, "Región del Maule", "Maule", "Linares", "Longaví"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7404, 7, 74, -71.4463212218, -71.6466288589, "Región del Maule", "Maule", "Linares", "Parral"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7405, 7, 74, -71.4463212218, -71.8299458071, "Región del Maule", "Maule", "Linares", "Retiro"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7406, 7, 74, -71.4463212218, -71.9270734738, "Región del Maule", "Maule", "Linares", "San Javier"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7407, 7, 74, -71.4463212218, -71.6829346305, "Región del Maule", "Maule", "Linares", "Villa Alegre"));
            municipios.Add(new MUNICIPIO_LOCALIZA(7408, 7, 74, -71.4463212218, -71.5441161205, "Región del Maule", "Maule", "Linares", "Yerbas Buenas"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8101, 8, 81, -72.2634281286, -72.9508292392, "Región del Biobío", "Biobío", "Concepción", "Concepción"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8102, 8, 81, -72.2634281286, -73.1255841444, "Región del Biobío", "Biobío", "Concepción", "Coronel"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8103, 8, 81, -72.2634281286, -73.0051869676, "Región del Biobío", "Biobío", "Concepción", "Chiguayante"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8104, 8, 81, -72.2634281286, -72.7177998529, "Región del Biobío", "Biobío", "Concepción", "Florida"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8105, 8, 81, -72.2634281286, -72.8710349587, "Región del Biobío", "Biobío", "Concepción", "Hualqui"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8106, 8, 81, -72.2634281286, -73.1049584928, "Región del Biobío", "Biobío", "Concepción", "Lota"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8107, 8, 81, -72.2634281286, -72.9437440844, "Región del Biobío", "Biobío", "Concepción", "Penco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8108, 8, 81, -72.2634281286, -73.098476665, "Región del Biobío", "Biobío", "Concepción", "San Pedro de la Paz"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8109, 8, 81, -72.2634281286, -72.9600558162, "Región del Biobío", "Biobío", "Concepción", "Santa Juana"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8110, 8, 81, -72.2634281286, -73.099437088, "Región del Biobío", "Biobío", "Concepción", "Talcahuano"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8111, 8, 81, -72.2634281286, -72.8580501099, "Región del Biobío", "Biobío", "Concepción", "Tomé"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8112, 8, 81, -72.2634281286, -73.141186622, "Región del Biobío", "Biobío", "Concepción", "Hualpén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8201, 8, 82, -72.2634281286, -73.5898697354, "Región del Biobío", "Biobío", "Arauco", "Lebu"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8202, 8, 82, -72.2634281286, -73.3998060091, "Región del Biobío", "Biobío", "Arauco", "Arauco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8203, 8, 82, -72.2634281286, -73.3173011876, "Región del Biobío", "Biobío", "Arauco", "Cañete"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8204, 8, 82, -72.2634281286, -73.2119647769, "Región del Biobío", "Biobío", "Arauco", "Contulmo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8205, 8, 82, -72.2634281286, -73.2356455822, "Región del Biobío", "Biobío", "Arauco", "Curanilahue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8206, 8, 82, -72.2634281286, -73.3569413528, "Región del Biobío", "Biobío", "Arauco", "Los Alamos"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8207, 8, 82, -72.2634281286, -73.3944052784, "Región del Biobío", "Biobío", "Arauco", "Tirúa"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8301, 8, 83, -72.2634281286, -72.3274299995, "Región del Biobío", "Biobío", "Biobío", "Los Angeles"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8302, 8, 83, -72.2634281286, -71.3670325939, "Región del Biobío", "Biobío", "Biobío", "Antuco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8303, 8, 83, -72.2634281286, -72.3813599006, "Región del Biobío", "Biobío", "Biobío", "Cabrero"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8304, 8, 83, -72.2634281286, -72.5825330104, "Región del Biobío", "Biobío", "Biobío", "Laja"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8305, 8, 83, -72.2634281286, -72.0977882402, "Región del Biobío", "Biobío", "Biobío", "Mulchén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8306, 8, 83, -72.2634281286, -72.823547161, "Región del Biobío", "Biobío", "Biobío", "Nacimiento"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8307, 8, 83, -72.2634281286, -72.5763606925, "Región del Biobío", "Biobío", "Biobío", "Negrete"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8308, 8, 83, -72.2634281286, -71.7056814327, "Región del Biobío", "Biobío", "Biobío", "Quilaco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8309, 8, 83, -72.2634281286, -71.8615463754, "Región del Biobío", "Biobío", "Biobío", "Quilleco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8310, 8, 83, -72.2634281286, -72.7212581436, "Región del Biobío", "Biobío", "Biobío", "San Rosendo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8311, 8, 83, -72.2634281286, -71.7482059274, "Región del Biobío", "Biobío", "Biobío", "Santa Bárbara"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8312, 8, 83, -72.2634281286, -71.7443488027, "Región del Biobío", "Biobío", "Biobío", "Tucapel"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8313, 8, 83, -72.2634281286, -72.616051762, "Región del Biobío", "Biobío", "Biobío", "Yumbel"));
            municipios.Add(new MUNICIPIO_LOCALIZA(8314, 8, 83, -72.2634281286, -71.3474499917, "Región del Biobío", "Biobío", "Biobío", "Alto Biobío"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16101, 16, 161, -72.2634281286, -72.1287244312, "Región de Ñuble", "Ñuble", "Diguillín", "Chillán"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16102, 16, 161, -72.2634281286, -72.2900215842, "Región de Ñuble", "Ñuble", "Diguillín", "Bulnes"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16202, 16, 162, -72.2634281286, -72.7205933691, "Región de Ñuble", "Ñuble", "Itata", "Cobquecura"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16203, 16, 162, -72.2634281286, -72.7504237915, "Región de Ñuble", "Ñuble", "Itata", "Coelemu"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16302, 16, 163, -72.2634281286, -71.5817371361, "Región de Ñuble", "Ñuble", "Punilla", "Coihueco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16103, 16, 161, -72.2634281286, -72.1988051799, "Región de Ñuble", "Ñuble", "Diguillín", "Chillán Viejo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16104, 16, 161, -72.2634281286, -71.8471105616, "Región de Ñuble", "Ñuble", "Diguillín", "El Carmen"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16204, 16, 162, -72.2634281286, -72.4097067642, "Región de Ñuble", "Ñuble", "Itata", "Ninhue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16303, 16, 163, -72.2634281286, -71.8979040739, "Región de Ñuble", "Ñuble", "Punilla", "Ñiquén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16105, 16, 161, -72.2634281286, -72.0678475373, "Región de Ñuble", "Ñuble", "Diguillín", "Pemuco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16106, 16, 161, -72.2634281286, -71.4999442772, "Región de Ñuble", "Ñuble", "Diguillín", "Pinto"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16205, 16, 162, -72.2634281286, -72.4666382514, "Región de Ñuble", "Ñuble", "Itata", "Portezuelo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16107, 16, 161, -72.2634281286, -72.5018054716, "Región de Ñuble", "Ñuble", "Diguillín", "Quillón"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16201, 16, 162, -72.2634281286, -72.5436475817, "Región de Ñuble", "Ñuble", "Itata", "Quirihue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16206, 16, 162, -72.2634281286, -72.5879597646, "Región de Ñuble", "Ñuble", "Itata", "Ránquil"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16301, 16, 163, -72.2634281286, -72.019057169, "Región de Ñuble", "Ñuble", "Punilla", "San Carlos"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16304, 16, 163, -72.2634281286, -71.2877565913, "Región de Ñuble", "Ñuble", "Punilla", "San Fabián"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16108, 16, 161, -72.2634281286, -72.0294015314, "Región de Ñuble", "Ñuble", "Diguillín", "San Ignacio"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16305, 16, 163, -72.2634281286, -72.2283817817, "Región de Ñuble", "Ñuble", "Punilla", "San Nicolás"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16207, 16, 162, -72.2634281286, -72.6597876752, "Región de Ñuble", "Ñuble", "Itata", "Treguaco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(16109, 16, 161, -72.2634281286, -71.9305829323, "Región de Ñuble", "Ñuble", "Diguillín", "Yungay"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9101, 9, 91, -72.276375641, -72.6677671889, "Región de La Araucanía", "La Araucanía", "Cautín", "Temuco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9102, 9, 91, -72.276375641, -73.2695568969, "Región de La Araucanía", "La Araucanía", "Cautín", "Carahue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9103, 9, 91, -72.276375641, -71.9922993971, "Región de La Araucanía", "La Araucanía", "Cautín", "Cunco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9104, 9, 91, -72.276375641, -71.5391563454, "Región de La Araucanía", "La Araucanía", "Cautín", "Curarrehue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9105, 9, 91, -72.276375641, -72.5763040704, "Región de La Araucanía", "La Araucanía", "Cautín", "Freire"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9106, 9, 91, -72.276375641, -72.7917283082, "Región de La Araucanía", "La Araucanía", "Cautín", "Galvarino"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9107, 9, 91, -72.276375641, -72.669618655, "Región de La Araucanía", "La Araucanía", "Cautín", "Gorbea"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9108, 9, 91, -72.276375641, -72.289099197, "Región de La Araucanía", "La Araucanía", "Cautín", "Lautaro"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9109, 9, 91, -72.276375641, -72.5829141628, "Región de La Araucanía", "La Araucanía", "Cautín", "Loncoche"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9110, 9, 91, -72.276375641, -71.6108924678, "Región de La Araucanía", "La Araucanía", "Cautín", "Melipeuco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9111, 9, 91, -72.276375641, -72.9720610851, "Región de La Araucanía", "La Araucanía", "Cautín", "Nueva Imperial"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9112, 9, 91, -72.276375641, -72.5788411915, "Región de La Araucanía", "La Araucanía", "Cautín", "Padre las Casas"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9113, 9, 91, -72.276375641, -72.4366359412, "Región de La Araucanía", "La Araucanía", "Cautín", "Perquenco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9114, 9, 91, -72.276375641, -72.6638092543, "Región de La Araucanía", "La Araucanía", "Cautín", "Pitrufquén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9115, 9, 91, -72.276375641, -71.7912464818, "Región de La Araucanía", "La Araucanía", "Cautín", "Pucón"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9116, 9, 91, -72.276375641, -73.2955377625, "Región de La Araucanía", "La Araucanía", "Cautín", "Saavedra"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9117, 9, 91, -72.276375641, -73.1274865658, "Región de La Araucanía", "La Araucanía", "Cautín", "Teodoro Schmidt"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9118, 9, 91, -72.276375641, -73.065775374, "Región de La Araucanía", "La Araucanía", "Cautín", "Toltén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9119, 9, 91, -72.276375641, -72.116504654, "Región de La Araucanía", "La Araucanía", "Cautín", "Vilcún"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9120, 9, 91, -72.276375641, -72.1828309674, "Región de La Araucanía", "La Araucanía", "Cautín", "Villarrica"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9121, 9, 91, -72.276375641, -72.9023872851, "Región de La Araucanía", "La Araucanía", "Cautín", "Cholchol"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9201, 9, 92, -72.276375641, -72.7957142527, "Región de La Araucanía", "La Araucanía", "Malleco", "Angol"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9202, 9, 92, -72.276375641, -72.1247823882, "Región de La Araucanía", "La Araucanía", "Malleco", "Collipulli"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9203, 9, 92, -72.276375641, -71.7720702181, "Región de La Araucanía", "La Araucanía", "Malleco", "Curacautín"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9204, 9, 92, -72.276375641, -72.3531374892, "Región de La Araucanía", "La Araucanía", "Malleco", "Ercilla"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9205, 9, 92, -72.276375641, -71.2397410148, "Región de La Araucanía", "La Araucanía", "Malleco", "Lonquimay"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9206, 9, 92, -72.276375641, -72.7969068396, "Región de La Araucanía", "La Araucanía", "Malleco", "Los Sauces"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9207, 9, 92, -72.276375641, -73.0457005279, "Región de La Araucanía", "La Araucanía", "Malleco", "Lumaco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9208, 9, 92, -72.276375641, -73.0504211711, "Región de La Araucanía", "La Araucanía", "Malleco", "Purén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9209, 9, 92, -72.276375641, -72.5755910381, "Región de La Araucanía", "La Araucanía", "Malleco", "Renaico"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9210, 9, 92, -72.276375641, -72.6549810073, "Región de La Araucanía", "La Araucanía", "Malleco", "Traiguén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(9211, 9, 92, -72.276375641, -72.2335936461, "Región de La Araucanía", "La Araucanía", "Malleco", "Victoria"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10101, 10, 101, -72.2068049418, -72.7955813241, "Región de Los Lagos", "Los Lagos", "Llanquihue", "Puerto Montt"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10102, 10, 101, -72.2068049418, -73.1948686881, "Región de Los Lagos", "Los Lagos", "Llanquihue", "Calbuco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10103, 10, 101, -72.2068049418, -72.0917081076, "Región de Los Lagos", "Los Lagos", "Llanquihue", "Cochamó"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10104, 10, 101, -72.2068049418, -73.6067200675, "Región de Los Lagos", "Los Lagos", "Llanquihue", "Fresia"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10105, 10, 101, -72.2068049418, -73.0959170387, "Región de Los Lagos", "Los Lagos", "Llanquihue", "Frutillar"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10106, 10, 101, -72.2068049418, -73.5818323869, "Región de Los Lagos", "Los Lagos", "Llanquihue", "Los Muermos"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10107, 10, 101, -72.2068049418, -73.1396596418, "Región de Los Lagos", "Los Lagos", "Llanquihue", "Llanquihue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10108, 10, 101, -72.2068049418, -73.5026860801, "Región de Los Lagos", "Los Lagos", "Llanquihue", "Maullín"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10109, 10, 101, -72.2068049418, -72.3881107087, "Región de Los Lagos", "Los Lagos", "Llanquihue", "Puerto Varas"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10201, 10, 102, -72.2068049418, -73.8046191297, "Región de Los Lagos", "Los Lagos", "Chiloé", "Castro"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10202, 10, 102, -72.2068049418, -73.8013178115, "Región de Los Lagos", "Los Lagos", "Chiloé", "Ancud"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10203, 10, 102, -72.2068049418, -73.9306025761, "Región de Los Lagos", "Los Lagos", "Chiloé", "Chonchi"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10204, 10, 102, -72.2068049418, -73.5786872572, "Región de Los Lagos", "Los Lagos", "Chiloé", "Curaco de Vélez"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10205, 10, 102, -72.2068049418, -73.8332952253, "Región de Los Lagos", "Los Lagos", "Chiloé", "Dalcahue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10206, 10, 102, -72.2068049418, -73.6370931112, "Región de Los Lagos", "Los Lagos", "Chiloé", "Puqueldón"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10207, 10, 102, -72.2068049418, -73.5643440522, "Región de Los Lagos", "Los Lagos", "Chiloé", "Queilén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10208, 10, 102, -72.2068049418, -73.9939296615, "Región de Los Lagos", "Los Lagos", "Chiloé", "Quellón"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10209, 10, 102, -72.2068049418, -73.4114986361, "Región de Los Lagos", "Los Lagos", "Chiloé", "Quemchi"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10210, 10, 102, -72.2068049418, -73.3589227833, "Región de Los Lagos", "Los Lagos", "Chiloé", "Quinchao"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10301, 10, 103, -72.2068049418, -73.0867453662, "Región de Los Lagos", "Los Lagos", "Osorno", "Osorno"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10302, 10, 103, -72.2068049418, -72.5996861674, "Región de Los Lagos", "Los Lagos", "Osorno", "Puerto Octay"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10303, 10, 103, -72.2068049418, -73.4579156099, "Región de Los Lagos", "Los Lagos", "Osorno", "Purranque"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10304, 10, 103, -72.2068049418, -72.384008281, "Región de Los Lagos", "Los Lagos", "Osorno", "Puyehue"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10305, 10, 103, -72.2068049418, -73.4176981519, "Región de Los Lagos", "Los Lagos", "Osorno", "Río Negro"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10306, 10, 103, -72.2068049418, -73.5591952549, "Región de Los Lagos", "Los Lagos", "Osorno", "San Juan de La Costa"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10307, 10, 103, -72.2068049418, -73.1616793387, "Región de Los Lagos", "Los Lagos", "Osorno", "San Pablo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10401, 10, 104, -72.2068049418, -72.5758267231, "Región de Los Lagos", "Los Lagos", "Palena", "Chaitén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10402, 10, 104, -72.2068049418, -72.0071718855, "Región de Los Lagos", "Los Lagos", "Palena", "Futaleufú"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10403, 10, 104, -72.2068049418, -72.3775160289, "Región de Los Lagos", "Los Lagos", "Palena", "Hualaihué"));
            municipios.Add(new MUNICIPIO_LOCALIZA(10404, 10, 104, -72.2068049418, -71.9835777041, "Región de Los Lagos", "Los Lagos", "Palena", "Palena"));
            municipios.Add(new MUNICIPIO_LOCALIZA(11101, 11, 111, -73.0158195419, -71.99173699, "Región del General Carlos Ibañez del Campo", "Aysén", "Coihaique", "Coihaique"));
            municipios.Add(new MUNICIPIO_LOCALIZA(11102, 11, 111, -73.0158195419, -71.8342823809, "Región del General Carlos Ibañez del Campo", "Aysén", "Coihaique", "Lago Verde"));
            municipios.Add(new MUNICIPIO_LOCALIZA(11201, 11, 112, -73.0158195419, -73.765003751, "Región del General Carlos Ibañez del Campo", "Aysén", "Aisén", "Aisén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(11202, 11, 112, -73.0158195419, -73.1371398973, "Región del General Carlos Ibañez del Campo", "Aysén", "Aisén", "Cisnes"));
            municipios.Add(new MUNICIPIO_LOCALIZA(11203, 11, 112, -73.0158195419, -73.837636296, "Región del General Carlos Ibañez del Campo", "Aysén", "Aisén", "Guaitecas"));
            municipios.Add(new MUNICIPIO_LOCALIZA(11301, 11, 113, -73.0158195419, -72.7436231209, "Región del General Carlos Ibañez del Campo", "Aysén", "Capitán Prat", "Cochrane"));
            municipios.Add(new MUNICIPIO_LOCALIZA(11302, 11, 113, -73.0158195419, -72.9090271193, "Región del General Carlos Ibañez del Campo", "Aysén", "Capitán Prat", "O'Higgins"));
            municipios.Add(new MUNICIPIO_LOCALIZA(11303, 11, 113, -73.0158195419, -74.1672029134, "Región del General Carlos Ibañez del Campo", "Aysén", "Capitán Prat", "Tortel"));
            municipios.Add(new MUNICIPIO_LOCALIZA(11401, 11, 114, -73.0158195419, -72.586427804, "Región del General Carlos Ibañez del Campo", "Aysén", "General Carrera", "Chile Chico"));
            municipios.Add(new MUNICIPIO_LOCALIZA(11402, 11, 114, -73.0158195419, -72.4875462731, "Región del General Carlos Ibañez del Campo", "Aysén", "General Carrera", "Río Ibáñez"));
            municipios.Add(new MUNICIPIO_LOCALIZA(12101, 12, 121, -70.0516354499, -72.0254461498, "Región de Magallanes y de la Antártica Chilena", "Magallanes", "Magallanes", "Punta Arenas"));
            municipios.Add(new MUNICIPIO_LOCALIZA(12102, 12, 121, -70.0516354499, -71.2403490256, "Región de Magallanes y de la Antártica Chilena", "Magallanes", "Magallanes", "Laguna Blanca"));
            municipios.Add(new MUNICIPIO_LOCALIZA(12103, 12, 121, -70.0516354499, -72.4573600267, "Región de Magallanes y de la Antártica Chilena", "Magallanes", "Magallanes", "Río Verde"));
            municipios.Add(new MUNICIPIO_LOCALIZA(12104, 12, 121, -70.0516354499, -70.1959724678, "Región de Magallanes y de la Antártica Chilena", "Magallanes", "Magallanes", "San Gregorio"));
            municipios.Add(new MUNICIPIO_LOCALIZA(12201, 12, 122, -70.0516354499, -69.2676114487, "Región de Magallanes y de la Antártica Chilena", "Magallanes", "Antártica Chilena", "Cabo de Hornos"));
            municipios.Add(new MUNICIPIO_LOCALIZA(12301, 12, 123, -70.0516354499, -69.3800932016, "Región de Magallanes y de la Antártica Chilena", "Magallanes", "Tierra del Fuego", "Porvenir"));
            municipios.Add(new MUNICIPIO_LOCALIZA(12302, 12, 123, -70.0516354499, -69.3296827829, "Región de Magallanes y de la Antártica Chilena", "Magallanes", "Tierra del Fuego", "Primavera"));
            municipios.Add(new MUNICIPIO_LOCALIZA(12303, 12, 123, -70.0516354499, -69.5343339111, "Región de Magallanes y de la Antártica Chilena", "Magallanes", "Tierra del Fuego", "Timaukel"));
            municipios.Add(new MUNICIPIO_LOCALIZA(12401, 12, 124, -70.0516354499, -73.9834575532, "Región de Magallanes y de la Antártica Chilena", "Magallanes", "Ultima Esperanza", "Natales"));
            municipios.Add(new MUNICIPIO_LOCALIZA(12402, 12, 124, -70.0516354499, -72.8137769353, "Región de Magallanes y de la Antártica Chilena", "Magallanes", "Ultima Esperanza", "Torres del Paine"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13101, 13, 131, -70.6266370305, -70.6569543965, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Santiago"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13102, 13, 131, -70.6266370305, -70.712543579, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Cerrillos"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13103, 13, 131, -70.6266370305, -70.7445869321, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Cerro Navia"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13104, 13, 131, -70.6266370305, -70.6769054419, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Conchalí"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13105, 13, 131, -70.6266370305, -70.6763067367, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "El Bosque"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13106, 13, 131, -70.6266370305, -70.7009892068, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Estación Central"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13107, 13, 131, -70.6266370305, -70.6382097062, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Huechuraba"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13108, 13, 131, -70.6266370305, -70.6652854661, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Independencia"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13109, 13, 131, -70.6266370305, -70.6639942163, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "La Cisterna"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13110, 13, 131, -70.6266370305, -70.5399741188, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "La Florida"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13111, 13, 131, -70.6266370305, -70.6226262658, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "La Granja"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13112, 13, 131, -70.6266370305, -70.6372519122, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "La Pintana"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13113, 13, 131, -70.6266370305, -70.5368973286, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "La Reina"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13114, 13, 131, -70.6266370305, -70.5013173991, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Las Condes"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13115, 13, 131, -70.6266370305, -70.3686132049, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Lo Barnechea"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13116, 13, 131, -70.6266370305, -70.6900083545, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Lo Espejo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13117, 13, 131, -70.6266370305, -70.7232074374, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Lo Prado"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13118, 13, 131, -70.6266370305, -70.6003158286, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Macul"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13119, 13, 131, -70.6266370305, -70.8097575548, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Maipú"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13120, 13, 131, -70.6266370305, -70.5991274507, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Ñuñoa"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13121, 13, 131, -70.6266370305, -70.6756529433, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Pedro Aguirre Cerda"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13122, 13, 131, -70.6266370305, -70.525497685, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Peñalolén"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13123, 13, 131, -70.6266370305, -70.6124427502, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Providencia"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13124, 13, 131, -70.6266370305, -70.8548358134, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Pudahuel"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13125, 13, 131, -70.6266370305, -70.7354190659, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Quilicura"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13126, 13, 131, -70.6266370305, -70.7013745412, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Quinta Normal"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13127, 13, 131, -70.6266370305, -70.6395869549, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Recoleta"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13128, 13, 131, -70.6266370305, -70.727935172, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Renca"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13129, 13, 131, -70.6266370305, -70.6287005921, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "San Joaquín"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13130, 13, 131, -70.6266370305, -70.6517764643, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "San Miguel"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13131, 13, 131, -70.6266370305, -70.6423153126, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "San Ramón"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13132, 13, 131, -70.6266370305, -70.5731304191, "Región Metropolitana de Santiago", "Metropolitana", "Santiago", "Vitacura"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13201, 13, 132, -70.6266370305, -70.5579820209, "Región Metropolitana de Santiago", "Metropolitana", "Cordillera", "Puente Alto"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13202, 13, 132, -70.6266370305, -70.5068294787, "Región Metropolitana de Santiago", "Metropolitana", "Cordillera", "Pirque"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13203, 13, 132, -70.6266370305, -70.0965071709, "Región Metropolitana de Santiago", "Metropolitana", "Cordillera", "San José de Maipo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13301, 13, 133, -70.6266370305, -70.6160981639, "Región Metropolitana de Santiago", "Metropolitana", "Chacabuco", "Colina"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13302, 13, 133, -70.6266370305, -70.8751595286, "Región Metropolitana de Santiago", "Metropolitana", "Chacabuco", "Lampa"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13303, 13, 133, -70.6266370305, -70.8761884235, "Región Metropolitana de Santiago", "Metropolitana", "Chacabuco", "Tiltil"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13401, 13, 134, -70.6266370305, -70.724181018, "Región Metropolitana de Santiago", "Metropolitana", "Maipo", "San Bernardo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13402, 13, 134, -70.6266370305, -70.7389422429, "Región Metropolitana de Santiago", "Metropolitana", "Maipo", "Buin"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13403, 13, 134, -70.6266370305, -70.7902285336, "Región Metropolitana de Santiago", "Metropolitana", "Maipo", "Calera de Tango"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13404, 13, 134, -70.6266370305, -70.7583137013, "Región Metropolitana de Santiago", "Metropolitana", "Maipo", "Paine"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13501, 13, 135, -70.6266370305, -71.1936904819, "Región Metropolitana de Santiago", "Metropolitana", "Melipilla", "Melipilla"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13502, 13, 135, -70.6266370305, -71.0564425064, "Región Metropolitana de Santiago", "Metropolitana", "Melipilla", "Alhué"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13503, 13, 135, -70.6266370305, -71.0801315878, "Región Metropolitana de Santiago", "Metropolitana", "Melipilla", "Curacaví"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13504, 13, 135, -70.6266370305, -71.2104003581, "Región Metropolitana de Santiago", "Metropolitana", "Melipilla", "María Pinto"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13505, 13, 135, -70.6266370305, -71.4527103289, "Región Metropolitana de Santiago", "Metropolitana", "Melipilla", "San Pedro"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13601, 13, 136, -70.6266370305, -70.8954488379, "Región Metropolitana de Santiago", "Metropolitana", "Talagante", "Talagante"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13602, 13, 136, -70.6266370305, -71.0335418234, "Región Metropolitana de Santiago", "Metropolitana", "Talagante", "El Monte"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13603, 13, 136, -70.6266370305, -70.9459116223, "Región Metropolitana de Santiago", "Metropolitana", "Talagante", "Isla de Maipo"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13604, 13, 136, -70.6266370305, -70.8710073491, "Región Metropolitana de Santiago", "Metropolitana", "Talagante", "Padre Hurtado"));
            municipios.Add(new MUNICIPIO_LOCALIZA(13605, 13, 136, -70.6266370305, -70.8937471949, "Región Metropolitana de Santiago", "Metropolitana", "Talagante", "Peñaflor"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14101, 14, 141, -72.5764331101, -73.1746908864, "Región de Los Ríos", "Los Ríos", "Valdivia", "Valdivia"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14102, 14, 141, -72.5764331101, -73.3716133312, "Región de Los Ríos", "Los Ríos", "Valdivia", "Corral"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14103, 14, 141, -72.5764331101, -72.6215188458, "Región de Los Ríos", "Los Ríos", "Valdivia", "Lanco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14104, 14, 141, -72.5764331101, -72.5546755679, "Región de Los Ríos", "Los Ríos", "Valdivia", "Los Lagos"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14105, 14, 141, -72.5764331101, -72.8639087599, "Región de Los Ríos", "Los Ríos", "Valdivia", "Máfil"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14106, 14, 141, -72.5764331101, -73.0192282365, "Región de Los Ríos", "Los Ríos", "Valdivia", "Mariquina"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14107, 14, 141, -72.5764331101, -72.8434415696, "Región de Los Ríos", "Los Ríos", "Valdivia", "Paillaco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14108, 14, 141, -72.5764331101, -72.0297441379, "Región de Los Ríos", "Los Ríos", "Valdivia", "Panguipulli"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14201, 14, 142, -72.5764331101, -73.2223210849, "Región de Los Ríos", "Los Ríos", "Ranco", "La Unión"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14202, 14, 142, -72.5764331101, -72.1160048195, "Región de Los Ríos", "Los Ríos", "Ranco", "Futrono"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14203, 14, 142, -72.5764331101, -72.1661660163, "Región de Los Ríos", "Los Ríos", "Ranco", "Lago Ranco"));
            municipios.Add(new MUNICIPIO_LOCALIZA(14204, 14, 142, -72.5764331101, -72.535439593, "Región de Los Ríos", "Los Ríos", "Ranco", "Río Bueno"));
            municipios.Add(new MUNICIPIO_LOCALIZA(15101, 15, 151, -69.6271472235, -69.9714910871, "Región de Arica y Parinacota", "Arica y Parinacota", "Arica", "Arica"));
            municipios.Add(new MUNICIPIO_LOCALIZA(15102, 15, 151, -69.6271472235, -69.7140563923, "Región de Arica y Parinacota", "Arica y Parinacota", "Arica", "Camarones"));
            municipios.Add(new MUNICIPIO_LOCALIZA(15201, 15, 152, -69.6271472235, -69.3101930709, "Región de Arica y Parinacota", "Arica y Parinacota", "Parinacota", "Putre"));
            municipios.Add(new MUNICIPIO_LOCALIZA(15202, 15, 152, -69.6271472235, -69.5707228083, "Región de Arica y Parinacota", "Arica y Parinacota", "Parinacota", "General Lagos"));
        }



        public string GetComuna(int codcom)
        {
            return this.municipios.Where(x => x.CODCOM == codcom).First().COMUNA;
        }

        public string GetRegion(int codreg)
        {
            return this.municipios.Where(x => x.CODREG == codreg).First().REGION_OFICIAL;
        }
    }

    public class MUNICIPIO_LOCALIZA
    {
        //Codcom	Codreg	Codprov	Lat Region	Lon Region	Lat Com	Lon Com	Región Oficial	Provincia	Comuna	Región

        public int CODCOM { get; set; }
        public int CODREG { get; set; }
        public int CODPROV { get; set; }
        public double LAT { get; set; }
        public double LON { get; set; }
        public string REGION_OFICIAL { get; set; }
        public string REGION { get; set; }
        public string PROVINCIA { get; set; }
        public string COMUNA { get; set; }

        public MUNICIPIO_LOCALIZA(int cODCOM, int cODREG, int cODPROV, double lAT, double lON, string rEGION_OFICIAL, string rEGION, string pROVINCIA, string cOMUNA)
        {
            CODCOM = cODCOM;
            CODREG = cODREG;
            CODPROV = cODPROV;
            LAT = lAT;
            LON = lON;
            REGION_OFICIAL = rEGION_OFICIAL;
            REGION = rEGION;
            PROVINCIA = pROVINCIA;
            COMUNA = cOMUNA;
        }
    }
}