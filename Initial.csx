{\rtf1\ansi\ansicpg1251\cocoartf2870
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 using System;\
using System.Collections.Generic;\
\
class Program\
\{\
    static List<int> Fibonacci(int n)\
    \{\
        var sequence = new List<int>();\
        int a = 0;\
        int b = 1;\
\
        for (int i = 0; i < n; i++)\
        \{\
            sequence.Add(a);\
            int next = a + b;\
            a = b;\
            b = next;\
        \}\
\
        return sequence;\
    \}\
\
    static void Main()\
    \{\
        Console.Write("How many Fibonacci numbers do you want? ");\
        string input = Console.ReadLine();\
\
        if (!int.TryParse(input, out int count) || count <= 0)\
        \{\
            Console.WriteLine("Please enter a positive integer.");\
            return;\
        \}\
\
        var result = Fibonacci(count);\
        Console.WriteLine($"First \{count\} Fibonacci numbers: \{string.Join(", ", result)\}");\
    \}\
\}}