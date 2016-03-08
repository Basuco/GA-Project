// Hello1.cs
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Hello1
{
   public static void Main()
   {
   		string[] lines = System.IO.File.ReadAllLines(@".\Datos.txt");
        string[] matriz = new string[690];
        int i = 0;
        int j,k,l;
        string temp;
        string resultado;
        float cont;
        char x;
	    l = 0;
	    foreach (string line in lines)
        {
        	temp = "";
        	resultado = "";

        	j = 1;
        	k = 0;
        	while (k < line.Length){
        		x = line[k];
        		if( x ==','){

        			// ######### A1 ##############
        			if (j == 1){
            			if (temp.Equals("b")){
            				resultado = resultado + "10";
            			}else if (temp.Equals("?")){
            				resultado = resultado + "11";
            			}else{
            				resultado = resultado + "01";
            			}
            		}// ######### A2 ##############
            		else if (j == 2){
            			if (temp.Equals("?")){
            				resultado = resultado + "111";
            			}else{
	            			cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
	            			if (cont < 25) {
	            				resultado = resultado + "100";
	            			}else if (cont < 39){
	            				resultado = resultado + "010";
	            			}else {
	            				resultado = resultado + "001";
	            			}
            			}
            		}// ######### A3 ##############
            		else if (j == 3){
            			cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
            			if (cont < 1) {
            				resultado = resultado + "1000";
            			}else if (cont < 5){
            				resultado = resultado + "0100";
            			}else if (cont <10){
            				resultado = resultado + "0010";
            			}else {
            				resultado = resultado + "0001";
            			}
            		}// ######### A4 ##############
            		else if (j == 4){
            			if (temp.Equals("u")){
            				resultado = resultado + "1000";
            			}else if (temp.Equals("y")){
            				resultado = resultado + "0100";
            			}else if (temp.Equals("l")){
            				resultado = resultado + "0010";
            			}else if (temp.Equals("?")){
            				resultado = resultado + "1111";
            			}else{
            				resultado = resultado + "0001";
            			}
            		}// ######### A5 ##############
            		else if (j == 5){
            			if (temp.Equals("g")){
            				resultado = resultado + "100";
            			}else if (temp.Equals("p")){
            				resultado = resultado + "010";
            			}else if (temp.Equals("?")){
            				resultado = resultado + "111";
            			}else{
            				resultado = resultado + "001";
            			}
            		}// ######### A6 ##############
            		else if (j == 6){
            			if (temp.Equals("c")){
            				resultado = resultado + "10000000000000";
            			}else if (temp.Equals("d")){
            				resultado = resultado + "01000000000000";
            			}else if (temp.Equals("cc")){
            				resultado = resultado + "00100000000000";
            			}else if (temp.Equals("i")){
            				resultado = resultado + "00010000000000";
            			}else if (temp.Equals("j")){
            				resultado = resultado + "00001000000000";
            			}else if (temp.Equals("k")){
            				resultado = resultado + "00000100000000";
            			}else if (temp.Equals("m")){
            				resultado = resultado + "00000010000000";
            			}else if (temp.Equals("r")){
            				resultado = resultado + "00000001000000";
            			}else if (temp.Equals("q")){
            				resultado = resultado + "00000000100000";
            			}else if (temp.Equals("w")){
            				resultado = resultado + "00000000010000";
            			}else if (temp.Equals("x")){
            				resultado = resultado + "00000000001000";
            			}else if (temp.Equals("e")){
            				resultado = resultado + "00000000000100";
            			}else if (temp.Equals("?")){
            				resultado = resultado + "11111111111111";
            			}else if (temp.Equals("aa")){
            				resultado = resultado + "00000000000010";
            			}else{
            				resultado = resultado + "00000000000001";
            			}
            		}// ######### A7 ##############
            		else if (j == 7){
            			if (temp.Equals("v")){
            				resultado = resultado + "100000000";
            			}else if (temp.Equals("h")){
            				resultado = resultado + "010000000";
            			}else if (temp.Equals("bb")){
            				resultado = resultado + "001000000";
            			}else if (temp.Equals("j")){
            				resultado = resultado + "000100000";
            			}else if (temp.Equals("n")){
            				resultado = resultado + "000010000";
            			}else if (temp.Equals("z")){
            				resultado = resultado + "000001000";
            			}else if (temp.Equals("dd")){
            				resultado = resultado + "000000100";
            			}else if (temp.Equals("ff")){
            				resultado = resultado + "000000010";
            			}else if (temp.Equals("?")){
            				resultado = resultado + "111111111";
            			}else{
            				resultado = resultado + "000000001";
            			}
            		}// ######### A8 ##############
            		else if (j == 8){
            			cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
            			if (cont < 0.04) {
            				resultado = resultado + "1000";
            			}else if (cont < 0.5){
            				resultado = resultado + "0100";
            			}else if (cont <10){
            				resultado = resultado + "0010";
            			}else {
            				resultado = resultado + "0001";
            			}
            		}// ######### A9 ##############
            		else if (j == 9){
            			if (temp.Equals("t")){
            				resultado = resultado + "10";
            			}else{
            				resultado = resultado + "01";
            			}
            		}// ######### A10 ##############
            		else if (j == 10){
            			if (temp.Equals("t")){
            				resultado = resultado + "10";
            			}else{
            				resultado = resultado + "01";
            			}
            		}// ######### A11 ##############
            		else if (j == 11){
            			cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
            			if (cont < 1) {
            				resultado = resultado + "10";
            			}else {
            				resultado = resultado + "01";
            			}
            		}// ######### A12 ##############
            		else if (j == 12){
            			if (temp.Equals("t")){
            				resultado = resultado + "10";
            			}else{
            				resultado = resultado + "01";
            			}
            		}// ######### A13 ##############
            		else if (j == 13){
            			if (temp.Equals("g")){
            				resultado = resultado + "100";
            			}else if (temp.Equals("p")){
            				resultado = resultado + "010";
            			}else{
            				resultado = resultado + "001";
            			}
            		}// ######### A14 ##############
            		else if (j == 14){
            			if (temp.Equals("?")){
            				resultado = resultado + "1111";
            			}else{

	            			cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
	            			if (cont < 20) {
	            				resultado = resultado + "1000";
	            			}else if (cont < 100){
	            				resultado = resultado + "0100";
	            			}else if (cont <200){
	            				resultado = resultado + "0010";
	            			}else {
	            				resultado = resultado + "0001";
	            			}
            			}
            		}// ######### A15 ##############
            		else if (j == 15){
            			cont = float.Parse(temp,System.Globalization.CultureInfo.InvariantCulture);
            			if (cont < 8) {
            				resultado = resultado + "1000";
            			}else if (cont < 100){
            				resultado = resultado + "0100";
            			}else if (cont <900){
            				resultado = resultado + "0010";
            			}else {
            				resultado = resultado + "0001";
            			}
            		}
            		j = j + 1;
            		temp = "";
            	}else if (k == line.Length-1){
            		if (line[k]=='+'){
            			resultado = resultado + "1";
            		}else{
            			resultado = resultado + "0";
            		}

            	}else{
            		temp = temp + x;
            	}
        		k = k+1;
        	}
        	l = l+1;
        	matriz[i] = resultado;
        	i = i+1;
        }
       	
       	k = 0; 
       	while (k < 690){
       		System.Console.WriteLine(matriz[k]);
       		k = k+1;
       	}

        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
   }
}