using System;
using System.IO;


public Country[] sortIncreasingByPopulation(){
    Country[] newArray= new Country[this.length];
    System.arraycopy(this.countries, srcPoc: 0, newArray, destPos:0, this.length);

    for(int i =0;  i < newArray.length;i++)
    {
        int minIndex =1;
        for(int j = i +1;  j < newArray.length - 1;i++){
            if(newArray[j].getPopulation() < newArray[minIndex].getPopulation()){
                minIndex =j;
            }
            //Swap

            Country temp =  newArray[minIndex];
            newArray[minIndex] = newArray[i];
            temp = newArray[i];
        }
        return newArray;
    
    }
}
public static String codeofCountriesToString(Country[] countries){
    StringBuilder  codeofCountries  = new StringBuilder();
    for(int i =0;  i < newArray.length;i++){
        Country country = countries[i];
        if(country != null){
            codeofCountries.append(country.getCode()).append(str:" ");
        }
    }
    return codeofCountries.toString().trim() + "]";

    codeofCountries.append(str:"[");

}

public static void testSortIncreasingByPopulation(){
    Country[] country =  countries;
    country =  countryManager.sortIncreasingByPopulation();
    countryManager.print(country);
}
