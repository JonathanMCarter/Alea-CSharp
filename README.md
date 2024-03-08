# Alea C#
A simple C# version of the Alea pseudo-random number generator (PRNG) originally created by Johannes Baagøe.
<br><br>
## Conception
I pretty much made this for a work project where I was trying to work out a random number generator to use between systems in C# & Javascript. The results needed to be the same and I came across Alea. Though there was no C# implementation that I could find, so I made this. 
<br><br>
I use this in my Unity code library <a href="https://github.com/CarterGames/The-Cart">here</a> if you want an example intergration. 
<br><br>
## How to use
First make an instance of the Alea number generator. Its not static to be the most flexible as you can enter the seed into the constructor. An example below: 
<br>
```
var alea = new Alea("MySeed");
```
<br>
To get a random number just call <code>Alea.Random()</code> from your instance to get a random number from the generator. An example below:
<br><br>

```
var alea = new Alea("MySeed");
var randomNumber = alea.Random();
```
## Licence
MIT Licence
