﻿// Copyright (C) 2019 Singapore ETH Centre, Future Cities Laboratory
// All rights reserved.
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//
// Author:  Michael Joos (joos@arch.ethz.ch)
//
// References:
//   6.3.2.1 Geographic Coordinate System Codes: http://geotiff.maptools.org/spec/geotiff6.html#6.3.2.1

public enum GeographicCoordinateSystem
{
	Undefined = 0,

	// EPSG GCS Based on Ellipsoid only
	// Note: the numeric code is equal to the code of the correspoding EPSG ellipsoid minus 3000
	Airy1830 = 4001,
	AiryModified1849 = 4002,
	AustralianNationalSpheroid = 4003,
	Bessel1841 = 4004,
	BesselModified = 4005,
	BesselNamibia = 4006,
	Clarke1858 = 4007,
	Clarke1866 = 4008,
	Clarke1866Michigan = 4009,
	Clarke1880_Benoit = 4010,
	Clarke1880_IGN = 4011,
	Clarke1880_RGS = 4012,
	Clarke1880_Arc = 4013,
	Clarke1880_SGA1922 = 4014,
	Everest1830_1937Adjustment = 4015,
	Everest1830_1967Definition = 4016,
	Everest1830_1975Definition = 4017,
	Everest1830Modified = 4018,
	GRS1980 = 4019,
	Helmert1906 = 4020,
	IndonesianNationalSpheroid = 4021,
	International1924 = 4022,
	International1967 = 4023,
	Krassowsky1940 = 4024,
	NWL9D = 4025,
	NWL10D = 4026,
	Plessis1817 = 4027,
	Struve1860 = 4028,
	WarOffice = 4029,
	WGS84 = 4030,
	GEM10C = 4031,
	OSU86F = 4032,
	OSU91A = 4033,
	Clarke1880 = 4034,
	Sphere = 4035,

	// EPSG GCS Based on EPSG Datum
	// Note: Geodetic datum using Greenwich PM have codes equal to the corresponding Datum code minus 2000
	Adindan = 4201,
	AGD66 = 4202,
	AGD84 = 4203,
	Ain_el_Abd = 4204,
	Afgooye = 4205,
	Agadez = 4206,
	Lisbon = 4207,
	Aratu = 4208,
	Arc_1950 = 4209,
	Arc_1960 = 4210,
	Batavia = 4211,
	Barbados = 4212,
	Beduaram = 4213,
	Beijing_1954 = 4214,
	Belge_1950 = 4215,
	Bermuda_1957 = 4216,
	Bern_1898 = 4217,
	Bogota = 4218,
	Bukit_Rimpah = 4219,
	Camacupa = 4220,
	Campo_Inchauspe = 4221,
	Cape = 4222,
	Carthage = 4223,
	Chua = 4224,
	Corrego_Alegre = 4225,
	Cote_d_Ivoire = 4226,
	Deir_ez_Zor = 4227,
	Douala = 4228,
	Egypt_1907 = 4229,
	ED50 = 4230,
	ED87 = 4231,
	Fahud = 4232,
	Gandajika_1970 = 4233,
	Garoua = 4234,
	Guyane_Francaise = 4235,
	Hu_Tzu_Shan = 4236,
	HD72 = 4237,
	ID74 = 4238,
	Indian_1954 = 4239,
	Indian_1975 = 4240,
	Jamaica_1875 = 4241,
	JAD69 = 4242,
	Kalianpur = 4243,
	Kandawala = 4244,
	Kertau = 4245,
	KOC = 4246,
	La_Canoa = 4247,
	PSAD56 = 4248,
	Lake = 4249,
	Leigon = 4250,
	Liberia_1964 = 4251,
	Lome = 4252,
	Luzon_1911 = 4253,
	Hito_XVIII_1963 = 4254,
	Herat_North = 4255,
	Mahe_1971 = 4256,
	Makassar = 4257,
	EUREF89 = 4258,
	Malongo_1987 = 4259,
	Manoca = 4260,
	Merchich = 4261,
	Massawa = 4262,
	Minna = 4263,
	Mhast = 4264,
	Monte_Mario = 4265,
	M_poraloko = 4266,
	NAD27 = 4267,
	NAD_Michigan = 4268,
	NAD83 = 4269,
	Nahrwan_1967 = 4270,
	Naparima_1972 = 4271,
	GD49 = 4272,
	NGO_1948 = 4273,
	Datum_73 = 4274,
	NTF = 4275,
	NSWC_9Z_2 = 4276,
	OSGB_1936 = 4277,
	OSGB70 = 4278,
	OS_SN80 = 4279,
	Padang = 4280,
	Palestine_1923 = 4281,
	Pointe_Noire = 4282,
	GDA94 = 4283,
	Pulkovo_1942 = 4284,
	Qatar = 4285,
	Qatar_1948 = 4286,
	Qornoq = 4287,
	Loma_Quintana = 4288,
	Amersfoort = 4289,
	RT38 = 4290,
	SAD69 = 4291,
	Sapper_Hill_1943 = 4292,
	Schwarzeck = 4293,
	Segora = 4294,
	Serindung = 4295,
	Sudan = 4296,
	Tananarive = 4297,
	Timbalai_1948 = 4298,
	TM65 = 4299,
	TM75 = 4300,
	Tokyo = 4301,
	Trinidad_1903 = 4302,
	TC_1948 = 4303,
	Voirol_1875 = 4304,
	Voirol_Unifie = 4305,
	Bern_1938 = 4306,
	Nord_Sahara_1959 = 4307,
	Stockholm_1938 = 4308,
	Yacare = 4309,
	Yoff = 4310,
	Zanderij = 4311,
	MGI = 4312,
	Belge_1972 = 4313,
	DHDN = 4314,
	Conakry_1905 = 4315,
	WGS_72 = 4322,
	WGS_72BE = 4324,
	WGS_84 = 4326,
	Bern_1898_Bern = 4801,
	Bogota_Bogota = 4802,
	Lisbon_Lisbon = 4803,
	Makassar_Jakarta = 4804,
	MGI_Ferro = 4805,
	Monte_Mario_Rome = 4806,
	NTF_Paris = 4807,
	Padang_Jakarta = 4808,
	Belge_1950_Brussels = 4809,
	Tananarive_Paris = 4810,
	Voirol_1875_Paris = 4811,
	Voirol_Unifie_Paris = 4812,
	Batavia_Jakarta = 4813,
	ATF_Paris = 4901,
	NDG_Paris = 4902,

	UserDefined = 32767,
}
