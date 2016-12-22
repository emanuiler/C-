using System;
using System.IO;

namespace _12.IDEs
{
    class Program
    {
        static void Main()
        {
            /*
             Worldwide, Oct 2016 compared to a year ago:

Rank
Change	IDE	Share	Trend
1		Visual Studio	22.7 %	-0.8 %
2		Eclipse	22.05 %	-5.9 %
3		Android Studio	10.47 %	+2.5 %
4		Vim	8.25 %	+0.3 %
5		NetBeans	5.59 %	-0.3 %
6		Xcode	5.48 %	-0.6 %
7		Sublime Text	4.45 %	+0.2 %
8		IntelliJ	4.26 %	+1.2 %
9		Komodo	3.74 %	+0.6 %
10		Xamarin	3.68 %	+2.3 %
11		Emacs	1.91 %	+0.1 %
12		pyCharm	1.64 %	+0.5 %
13		PhpStorm	1.58 %	+0.2 %
14		Light Table	1.07 %	+0.0 %
15		Cloud9	0.85 %	-0.2 %
16		Qt Creator	0.39 %	+0.0 %
17		JDeveloper	0.32 %	+0.0 %
18		Aptana	0.31 %	-0.1 %
19		geany	0.28 %	+0.0 %
20		MonoDevelop	0.23 %	+0.0 %
21		RubyMine	0.18 %	+0.0 %
22		JCreator	0.1 %	-0.1 %
23		SharpDevelop	0.09 %	+0.0 %
24		Monkey Studio	0.07 %	+0.0 %
25		Julia Studio	0.06 %	+0.0 %
26		Coda 2	0.06 %	+0.0 %
27		Zend Studio	0.06 %	+0.0 %
28		Eric Python	0.06 %	+0.0 %
29		DrJava	0.04 %	+0.0 %
30		SlickEdit	0.03 %	+0.0 %
             */
            string text = "  ";
            File.WriteAllText("output.txt", text);
        }
    }
}
