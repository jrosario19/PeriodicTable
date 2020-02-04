﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeriodicTable.Models;

namespace PeriodicTable.Controllers
{
    public class PeriodicTableController : Controller
    {
        public IActionResult GetPeriodicTable()
        {
            List<Element> elements = new List<Element>() {
                new Element(){
                    OrderNo=1,
                    Symbol = "H",
                    Name = "Hidrogeno",
                    Number = "1"
                },
                new Element(){
                    OrderNo=18,
                    Symbol = "He",
                    Name = "Helio",
                    Number = "1"
                },
                new Element(){
                    OrderNo=19,
                    Symbol = "Li",
                    Name = "Litio",
                    Number = "3"
                },
                new Element(){
                    OrderNo=20,
                    Symbol = "Be",
                    Name = "Berilio",
                    Number = "4"
                },
                new Element(){
                    OrderNo=31,
                    Symbol = "B",
                    Name = "Boro",
                    Number = "5"
                },
                new Element(){
                    OrderNo=32,
                    Symbol = "C",
                    Name = "Carbono",
                    Number = "6"
                },
                new Element(){
                    OrderNo=33,
                    Symbol = "N",
                    Name = "Nitrogeno",
                    Number = "7"
                },
                new Element(){
                    OrderNo=34,
                    Symbol = "O",
                    Name = "Oxigeno",
                    Number = "8"
                },
                new Element(){
                    OrderNo=35,
                    Symbol = "F",
                    Name = "Fluor",
                    Number = "9"
                },
                new Element(){
                    OrderNo=36,
                    Symbol = "Ne",
                    Name = "Neón",
                    Number = "10"
                },
                new Element(){
                    OrderNo=37,
                    Symbol = "Na",
                    Name = "Sodio",
                    Number = "11"
                },
                new Element(){
                    OrderNo=38,
                    Symbol = "Mg",
                    Name = "Magnesio",
                    Number = "12"
                },
                new Element(){
                    OrderNo=49,
                    Symbol = "Al",
                    Name = "Aluminio",
                    Number = "13"
                },
                new Element(){
                    OrderNo=50,
                    Symbol = "Si",
                    Name = "Silicio",
                    Number = "14"
                },
                new Element(){
                    OrderNo=51,
                    Symbol = "P",
                    Name = "Fósforo",
                    Number = "15"
                },
                new Element(){
                    OrderNo=52,
                    Symbol = "S",
                    Name = "Azufre",
                    Number = "16"
                },
                new Element(){
                    OrderNo=53,
                    Symbol = "Cl",
                    Name = "Cloro",
                    Number = "17"
                },
                new Element(){
                    OrderNo=54,
                    Symbol = "Ar",
                    Name = "Argón",
                    Number = "18"
                },
                new Element(){
                    OrderNo=55,
                    Symbol = "K",
                    Name = "Potasio",
                    Number = "19"
                },
                new Element(){
                    OrderNo=56,
                    Symbol = "Ca",
                    Name = "Calcio",
                    Number = "20"
                },
                new Element(){
                    OrderNo=57,
                    Symbol = "Sc",
                    Name = "Escandio",
                    Number = "21"
                },
                new Element(){
                    OrderNo=58,
                    Symbol = "Ti",
                    Name = "Titanio",
                    Number = "22"
                },
                new Element(){
                    OrderNo=59,
                    Symbol = "V",
                    Name = "Vanadio",
                    Number = "23"
                },
                new Element(){
                    OrderNo=60,
                    Symbol = "Cr",
                    Name = "Cromo",
                    Number = "24"
                },
                new Element(){
                    OrderNo=61,
                    Symbol = "Mn",
                    Name = "Manganesio",
                    Number = "25"
                },
                new Element(){
                    OrderNo=62,
                    Symbol = "Fe",
                    Name = "Hierro",
                    Number = "26"
                },
                new Element(){
                    OrderNo=63,
                    Symbol = "Co",
                    Name = "Cobalto",
                    Number = "27"
                },
                new Element(){
                    OrderNo=64,
                    Symbol = "Ni",
                    Name = "Niquel",
                    Number = "28"
                },
                new Element(){
                    OrderNo=65,
                    Symbol = "Cu",
                    Name = "Cobre",
                    Number = "29"
                },
                new Element(){
                    OrderNo=66,
                    Symbol = "Zn",
                    Name = "Zinc",
                    Number = "30"
                },
                new Element(){
                    OrderNo=67,
                    Symbol = "Ga",
                    Name = "Galio",
                    Number = "31"
                },
                new Element(){
                    OrderNo=68,
                    Symbol = "Ge",
                    Name = "Germanio",
                    Number = "32"
                },
                new Element(){
                    OrderNo=69,
                    Symbol = "As",
                    Name = "Arsénio",
                    Number = "33"
                },
                new Element(){
                    OrderNo=70,
                    Symbol = "Se",
                    Name = "Selenio",
                    Number = "34"
                },
                new Element(){
                    OrderNo=71,
                    Symbol = "Br",
                    Name = "Bromo",
                    Number = "35"
                },
                new Element(){
                    OrderNo=72,
                    Symbol = "Kr",
                    Name = "Kriptón",
                    Number = "36"
                },
                new Element(){
                    OrderNo=73,
                    Symbol = "Rb",
                    Name = "Rubidio",
                    Number = "37"
                },
                new Element(){
                    OrderNo=74,
                    Symbol = "Sr",
                    Name = "Estroncio",
                    Number = "38"
                },
                new Element(){
                    OrderNo=75,
                    Symbol = "Y",
                    Name = "Itrio",
                    Number = "39"
                },
                new Element(){
                    OrderNo=76,
                    Symbol = "Zr",
                    Name = "Circonio",
                    Number = "40"
                },
                new Element(){
                    OrderNo=77,
                    Symbol = "Nb",
                    Name = "Niobio",
                    Number = "41"
                },
                new Element(){
                    OrderNo=78,
                    Symbol = "Mo",
                    Name = "Molibdeno",
                    Number = "42"
                },
                new Element(){
                    OrderNo=79,
                    Symbol = "Tc",
                    Name = "Tecnesio",
                    Number = "43"
                },
                new Element(){
                    OrderNo=80,
                    Symbol = "Ru",
                    Name = "Rufenio",
                    Number = "44"
                },
                new Element(){
                    OrderNo=81,
                    Symbol = "Rh",
                    Name = "Rodio",
                    Number = "45"
                },
                new Element(){
                    OrderNo=82,
                    Symbol = "Pd",
                    Name = "Paladio",
                    Number = "46"
                },
                new Element(){
                    OrderNo=83,
                    Symbol = "Ag",
                    Name = "Plata",
                    Number = "47"
                },
                new Element(){
                    OrderNo=84,
                    Symbol = "Cd",
                    Name = "Cadmio",
                    Number = "48"
                },
                new Element(){
                    OrderNo=85,
                    Symbol = "In",
                    Name = "Indio",
                    Number = "49"
                },
                new Element(){
                    OrderNo=86,
                    Symbol = "Sn",
                    Name = "Estaño",
                    Number = "50"
                },
                new Element(){
                    OrderNo=87,
                    Symbol = "Sb",
                    Name = "Antimonio",
                    Number = "51"
                },
                new Element(){
                    OrderNo=88,
                    Symbol = "Te",
                    Name = "Telurio",
                    Number = "52"
                },
                new Element(){
                    OrderNo=89,
                    Symbol = "I",
                    Name = "Yodo",
                    Number = "53"
                },
                new Element(){
                    OrderNo=90,
                    Symbol = "Xe",
                    Name = "Xenón",
                    Number = "54"
                },
                new Element(){
                    OrderNo=91,
                    Symbol = "Cs",
                    Name = "Cesio",
                    Number = "55"
                },
                new Element(){
                    OrderNo=92,
                    Symbol = "Ba",
                    Name = "Bario",
                    Number = "56"
                },
                new Element(){
                    OrderNo=93,
                    Symbol = "La-Lu",
                    Name = "Lantanidos",
                    Number = "57-71"
                },
                new Element(){
                    OrderNo=94,
                    Symbol = "Hf",
                    Name = "Hafnio",
                    Number = "72"
                },
                new Element(){
                    OrderNo=95,
                    Symbol = "Ta",
                    Name = "Tantalio",
                    Number = "73"
                },
                new Element(){
                    OrderNo=96,
                    Symbol = "W",
                    Name = "Wolframio",
                    Number = "74"
                },
                new Element(){
                    OrderNo=97,
                    Symbol = "Re",
                    Name = "Renio",
                    Number = "75"
                },
                new Element(){
                    OrderNo=98,
                    Symbol = "Os",
                    Name = "Osmio",
                    Number = "76"
                },
                new Element(){
                    OrderNo=99,
                    Symbol = "Ir",
                    Name = "Iridio",
                    Number = "77"
                },
                new Element(){
                    OrderNo=100,
                    Symbol = "Pt",
                    Name = "Platino",
                    Number = "78"
                },
                new Element(){
                    OrderNo=101,
                    Symbol = "Au",
                    Name = "Oro",
                    Number = "79"
                },
                new Element(){
                    OrderNo=102,
                    Symbol = "Hg",
                    Name = "Mercurio",
                    Number = "80"
                },
                new Element(){
                    OrderNo=103,
                    Symbol = "TI",
                    Name = "Talio",
                    Number = "81"
                },
                new Element(){
                    OrderNo=104,
                    Symbol = "Pb",
                    Name = "Plomo",
                    Number = "82"
                },
                new Element(){
                    OrderNo=105,
                    Symbol = "Bi",
                    Name = "Bismuto",
                    Number = "83"
                },
                new Element(){
                    OrderNo=106,
                    Symbol = "Po",
                    Name = "Polonio",
                    Number = "84"
                },
                new Element(){
                    OrderNo=107,
                    Symbol = "At",
                    Name = "Astato",
                    Number = "85"
                },
                new Element(){
                    OrderNo=108,
                    Symbol = "Rn",
                    Name = "Radón",
                    Number = "86"
                },
                new Element(){
                    OrderNo=109,
                    Symbol = "Fr",
                    Name = "Francio",
                    Number = "87"
                },
                new Element(){
                    OrderNo=110,
                    Symbol = "Ra",
                    Name = "Radio",
                    Number = "88"
                },
                new Element(){
                    OrderNo=111,
                    Symbol = "Ac-Lr",
                    Name = "Actinidos",
                    Number = "89-103"
                },
                new Element(){
                    OrderNo=112,
                    Symbol = "Rf",
                    Name = "Rutherfordio",
                    Number = "104"
                },
                new Element(){
                    OrderNo=113,
                    Symbol = "Db",
                    Name = "Dubnio",
                    Number = "105"
                },
                new Element(){
                    OrderNo=114,
                    Symbol = "Sg",
                    Name = "Seaborgio",
                    Number = "106"
                },
                new Element(){
                    OrderNo=115,
                    Symbol = "Bh",
                    Name = "Bohrio",
                    Number = "107"
                },
                new Element(){
                    OrderNo=116,
                    Symbol = "Hs",
                    Name = "Hassio",
                    Number = "108"
                },
                new Element(){
                    OrderNo=117,
                    Symbol = "Mt",
                    Name = "Meitnerio",
                    Number = "109"
                },
                new Element(){
                    OrderNo=118,
                    Symbol = "Ds",
                    Name = "Darmstadio",
                    Number = "110"
                },
                new Element(){
                    OrderNo=119,
                    Symbol = "Rg",
                    Name = "Roentgenio",
                    Number = "111"
                },
                new Element(){
                    OrderNo=120,
                    Symbol = "Cn",
                    Name = "Copernicio",
                    Number = "112"
                },
                new Element(){
                    OrderNo=121,
                    Symbol = "Nh",
                    Name = "Nihonium",
                    Number = "113"
                },
                new Element(){
                    OrderNo=122,
                    Symbol = "FI",
                    Name = "Flerovio",
                    Number = "114"
                },
                new Element(){
                    OrderNo=123,
                    Symbol = "Mc",
                    Name = "Moscovium",
                    Number = "115"
                },
                new Element(){
                    OrderNo=124,
                    Symbol = "Lv",
                    Name = "Livermorio",
                    Number = "116"
                },
                new Element(){
                    OrderNo=125,
                    Symbol = "Ts",
                    Name = "Tennessine",
                    Number = "117"
                },
                new Element(){
                    OrderNo=126,
                    Symbol = "Og",
                    Name = "Oganesson",
                    Number = "118"
                },
                new Element(){
                    OrderNo=127,
                    Symbol = "La",
                    Name = "Lantano",
                    Number = "57"
                },
                new Element(){
                    OrderNo=128,
                    Symbol = "Ce",
                    Name = "Cerio",
                    Number = "58"
                },
                new Element(){
                    OrderNo=129,
                    Symbol = "Pr",
                    Name = "Praseodimio",
                    Number = "59"
                },
                new Element(){
                    OrderNo=130,
                    Symbol = "Nd",
                    Name = "Pm",
                    Number = "60"
                },
                new Element(){
                    OrderNo=131,
                    Symbol = "Pm",
                    Name = "Prometio",
                    Number = "61"
                },
                new Element(){
                    OrderNo=132,
                    Symbol = "Sm",
                    Name = "Samario",
                    Number = "62"
                },
                new Element(){
                    OrderNo=133,
                    Symbol = "Eu",
                    Name = "Europio",
                    Number = "63"
                },
                new Element(){
                    OrderNo=134,
                    Symbol = "Gd",
                    Name = "Gadolinio",
                    Number = "64"
                },
                new Element(){
                    OrderNo=135,
                    Symbol = "Tb",
                    Name = "Terbio",
                    Number = "65"
                },
                new Element(){
                    OrderNo=136,
                    Symbol = "Dy",
                    Name = "Disprosio",
                    Number = "66"
                },
                new Element(){
                    OrderNo=137,
                    Symbol = "Ho",
                    Name = "Holmio",
                    Number = "67"
                },
                new Element(){
                    OrderNo=138,
                    Symbol = "Er",
                    Name = "Erbio",
                    Number = "68"
                },
                new Element(){
                    OrderNo=139,
                    Symbol = "Tm",
                    Name = "Tulio",
                    Number = "69"
                },
                new Element(){
                    OrderNo=140,
                    Symbol = "Yb",
                    Name = "Iterbio",
                    Number = "70"
                },
                new Element(){
                    OrderNo=141,
                    Symbol = "Lu",
                    Name = "Lutesio",
                    Number = "71"
                },
                new Element(){
                    OrderNo=142,
                    Symbol = "Ac",
                    Name = "Actinio",
                    Number = "89"
                },
                new Element(){
                    OrderNo=143,
                    Symbol = "Th",
                    Name = "Torio",
                    Number = "90"
                },
                new Element(){
                    OrderNo=144,
                    Symbol = "Pa",
                    Name = "Protactinio",
                    Number = "91"
                },
                new Element(){
                    OrderNo=145,
                    Symbol = "U",
                    Name = "Uranio",
                    Number = "92"
                },
                new Element(){
                    OrderNo=146,
                    Symbol = "Np",
                    Name = "Neptunio",
                    Number = "93"
                },
                new Element(){
                    OrderNo=147,
                    Symbol = "Pu",
                    Name = "Plutonio",
                    Number = "94"
                },
                new Element(){
                    OrderNo=148,
                    Symbol = "Am",
                    Name = "Americio",
                    Number = "95"
                },
                new Element(){
                    OrderNo=149,
                    Symbol = "Cm",
                    Name = "Curio",
                    Number = "96"
                },
                new Element(){
                    OrderNo=150,
                    Symbol = "Bk",
                    Name = "Berkelio",
                    Number = "97"
                },
                new Element(){
                    OrderNo=151,
                    Symbol = "Cf",
                    Name = "Californio",
                    Number = "98"
                },
                new Element(){
                    OrderNo=152,
                    Symbol = "Es",
                    Name = "Einstenio",
                    Number = "99"
                },
                new Element(){
                    OrderNo=153,
                    Symbol = "Fm",
                    Name = "Fermio",
                    Number = "100"
                },
                new Element(){
                    OrderNo=154,
                    Symbol = "Md",
                    Name = "Mendelevio",
                    Number = "101"
                },
                new Element(){
                    OrderNo=155,
                    Symbol = "No",
                    Name = "Nobelio",
                    Number = "102"
                },
                new Element(){
                    OrderNo=156,
                    Symbol = "Lr",
                    Name = "Lawrencio",
                    Number = "103"
                }

            };
            return View(elements);
        }
    }
}