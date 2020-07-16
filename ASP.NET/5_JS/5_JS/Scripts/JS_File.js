//Действия с типами данных 
console.log((7 + 100) * 2);
 console.log((7+100)/2);
 console.log(10 % 4);//остаток от деления mod
 console.log("Hello JS!");//'' "" можно разные ковычки
 console.log("Don't do it!");
 console.log('She said: "HI"');
 console.log("She said: \"HI\"");
 console.log("Backslash:\\");
 console.log("k"+" "+"f");
 console.log("Hello world".length);
console.log("Hello world"[4]);

//Объекты
var personJack = {
    firstName: "Jack",
    lastName: "Petrov",
    age: 23,
    pets: ["cat", "dog", 'snake']
};
console.log(personJack.pets[1]);

//Функция
function decrement(x) {
    return x--;
}
console.log(decrement(23));

function twoReturns(y) {

    y = y - 8;

    console.log(y);
    return y;

    y = y + 8;
    console.log(y);

    return y;

}
twoReturns(10);