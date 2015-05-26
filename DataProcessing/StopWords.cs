﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSenti
{
    public static class StopWords
    {
        public static string[] stopWordsList = new string[]
        {
			"a", 																													  
			"about", 
			"above", 
			"across", 
			"afore", 
			"aforesaid", 
			"after", 
			"again", 
			"against", 
			"agin", 
			"ago", 
			"aint", 
			"albeit", 
			"all", 
			"almost", 
			"alone", 
			"along", 
			"alongside", 
			"already", 
			"also", 
			"although", 
			"always", 
			"am", 
			"american", 
			"amid", 
			"amidst", 
			"among", 
			"amongst", 
			"an", 
			"and", 
			"anent", 
			"another", 
			"any", 
			"anybody", 
			"anyone", 
			"anything", 
			"are", 
			"aren't", 
			"around", 
			"as", 
			"aslant", 
			"astride", 
			"at", 
			"athwart", 
			"away", 
			"b", 
			"back", 
			"bar", 
			"barring", 
			"be", 
			"because", 
			"been", 
			"before", 
			"behind", 
			"being", 
			"below", 
			"beneath", 
			"beside", 
			"besides", 
			"best", 
			"better", 
			"between", 
			"betwixt", 
			"beyond", 
			"both", 
			"but", 
			"by", 
			"c", 
			"can", 
			"cannot", 
			"can't", 
			"certain", 
			"circa", 
			"close", 
			"concerning", 
			"considering", 
			"cos", 
			"could", 
			"couldn't", 
			"couldst", 
			"d", 
			"dare", 
			"dared", 
			"daren't", 
			"dares", 
			"daring", 
			"despite", 
			"did", 
			"didn't", 
			"different", 
			"directly", 
			"do", 
			"does", 
			"doesn't", 
			"doing", 
			"done", 
			"don't", 
			"dost", 
			"doth", 
			"down", 
			"during", 
			"durst", 
			"e", 
			"each", 
			"early", 
			"either", 
			"em", 
			"english", 
			"enough", 
			"ere", 
			"even", 
			"ever", 
			"every", 
			"everybody", 
			"everyone", 
			"everything", 
			"except", 
			"excepting", 
			"f", 
			"failing", 
			"far", 
			"few", 
			"first", 
			"five", 
			"following", 
			"for", 
			"four", 
			"from", 
			"g", 
			"gonna", 
			"gotta", 
			"h", 
			"had", 
			"hadn't", 
			"hard", 
			"has", 
			"hasn't", 
			"hast", 
			"hath", 
			"have", 
			"haven't", 
			"having", 
			"he", 
			"he'd", 
			"he'll", 
			"her", 
			"here", 
			"here's", 
			"hers", 
			"herself", 
			"he's", 
			"high", 
			"him", 
			"himself", 
			"his", 
			"home", 
			"how", 
			"howbeit", 
			"however", 
			"how's", 
			"i", 
			"id", 
			"if", 
			"ill", 
			"i'm", 
			"immediately", 
			"important", 
			"in", 
			"inside", 
			"instantly", 
			"into", 
			"is", 
			"isn't", 
			"it", 
			"it'll", 
			"it's", 
			"its", 
			"itself", 
			"i've", 
			"j", 
			"just", 
			"k", 
			"l", 
			"large", 
			"last", 
			"later", 
			"least", 
			"left", 
			"less", 
			"lest", 
			"let's", 
			"like", 
			"likewise", 
			"little", 
			"living", 
			"long", 
			"m", 
			"many", 
			"may", 
			"mayn't", 
			"me", 
			"mid", 
			"midst", 
			"might", 
			"mightn't", 
			"mine", 
			"minus", 
			"more", 
			"most", 
			"much", 
			"must", 
			"mustn't", 
			"my", 
			"myself", 
			"n", 
			"near", 
			"'neath", 
			"need", 
			"needed", 
			"needing", 
			"needn't", 
			"needs", 
			"neither", 
			"never", 
			"nevertheless", 
			"new", 
			"next", 
			"nigh", 
			"nigher", 
			"nighest", 
			"nisi", 
			"no", 
			"no-one", 
			"nobody", 
			"none", 
			"nor", 
			"not", 
			"nothing", 
			"notwithstanding", 
			"now", 
			"o", 
			"o'er", 
			"of", 
			"off", 
			"often", 
			"on", 
			"once", 
			"one", 
			"oneself", 
			"only", 
			"onto", 
			"open", 
			"or", 
			"other", 
			"otherwise", 
			"ought", 
			"oughtn't", 
			"our", 
			"ours", 
			"ourselves", 
			"out", 
			"outside", 
			"over", 
			"own", 
			"p", 
			"past", 
			"pending", 
			"per", 
			"perhaps", 
			"plus", 
			"possible", 
			"present", 
			"probably", 
			"provided", 
			"providing", 
			"public", 
			"q", 
			"qua", 
			"quite", 
			"r", 
			"rather", 
			"re", 
			"real", 
			"really", 
			"respecting", 
			"right", 
			"round", 
			"s", 
			"same", 
			"sans", 
			"save", 
			"saving", 
			"second", 
			"several", 
			"shall", 
			"shalt", 
			"shan't", 
			"she", 
			"shed", 
			"shell", 
			"she's", 
			"short", 
			"should", 
			"shouldn't", 
			"since", 
			"six", 
			"small", 
			"so", 
			"some", 
			"somebody", 
			"someone", 
			"something", 
			"sometimes", 
			"soon", 
			"special", 
			"still", 
			"such", 
			"summat", 
			"supposing", 
			"sure", 
			"t", 
			"than", 
			"that", 
			"that'd", 
			"that'll", 
			"that's", 
			"the", 
			"thee", 
			"their", 
			"theirs", 
			"their's", 
			"them", 
			"themselves", 
			"then", 
			"there", 
			"there's", 
			"these", 
			"they", 
			"they'd", 
			"they'll", 
			"they're", 
			"they've", 
			"thine", 
			"this", 
			"tho", 
			"those", 
			"thou", 
			"though", 
			"three", 
			"thro'", 
			"through", 
			"throughout", 
			"thru", 
			"thyself", 
			"till", 
			"to", 
			"today", 
			"together", 
			"too", 
			"touching", 
			"toward", 
			"towards", 
			"true", 
			"'twas", 
			"'tween", 
			"'twere", 
			"'twill", 
			"'twixt", 
			"two", 
			"'twould", 
			"u", 
			"under", 
			"underneath", 
			"unless", 
			"unlike", 
			"until", 
			"unto", 
			"up", 
			"upon", 
			"us", 
			"used", 
			"usually", 
			"v", 
			"versus", 
			"very", 
			"via", 
			"vice", 
			"vis-a-vis", 
			"w", 
			"wanna", 
			"wanting", 
			"was", 
			"wasn't", 
			"way", 
			"we", 
			"we'd", 
			"well", 
			"were", 
			"weren't", 
			"wert", 
			"we've", 
			"what", 
			"whatever", 
			"what'll", 
			"what's", 
			"when", 
			"whencesoever", 
			"whenever", 
			"when's", 
			"whereas", 
			"where's", 
			"whether", 
			"which", 
			"whichever", 
			"whichsoever", 
			"while", 
			"whilst", 
			"who", 
			"who'd", 
			"whoever", 
			"whole", 
			"who'll", 
			"whom", 
			"whore", 
			"who's", 
			"whose", 
			"whoso", 
			"whosoever", 
			"will", 
			"with", 
			"within", 
			"without", 
			"wont", 
			"would", 
			"wouldn't", 
			"wouldst", 
			"x", 
			"y", 
			"ye", 
			"yet", 
			"you", 
			"you'd", 
			"you'll", 
			"your", 
			"you're", 
			"yours", 
			"yourself", 
			"yourselves", 
			"you've", 
			"z", 
		};
    }
}
