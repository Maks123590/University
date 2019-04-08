const getRandom = (min, max) => {
  let rand = min - 0.5 + Math.random() * (max - min + 1);
  rand = Math.round(rand);
  return rand;
};

const eratosphenMethod = (valueFrom = 2, valueTo) => {
  const booleanArray = [];

  for (var i = 2; i < valueTo; i++) {
    booleanArray[i] = true;
  }

  let p = 2;

  do {
    for (i = 2 * p; i < valueTo; i += p) {
      booleanArray[i] = false;
    }

    for (i = p + 1; i < valueTo; i++) {
      if (booleanArray[i]) break;
    }

    p = i;
  } while (p * p < valueTo);

  return booleanArray;
};

const smallTheoremePherma = (a, valueTo) => {
  const arr = [];
  for (let i = 0; i <= valueTo; i++) {
    arr[i] = true;
  }

  arr[0] = false;
  arr[1] = false;

  for (let i = 2; i <= valueTo; i++) {
    if (Math.pow(a, i - 1) % i !== 1) {
      arr[i] = false;
    }
  }

  return arr;
};

const getResultArray = array => {
  const resultArray = [];

  array.forEach((item, index) => {
    if (item) {
      resultArray.push(index);
    }
  });

  return resultArray;
};

const handleChangeSecondTask = event => {
  const valueFrom = from.value;
  const valueTo = to.value;
  const constA = a.value;

  const booleanArray = eratosphenMethod(valueFrom, valueTo);
  const result = getResultArray(booleanArray);
  const thPherme = smallTheoremePherma(constA, valueTo);
  const resultPherma = getResultArray(thPherme);
  document.querySelector(".resultSecondTasckEratosphen").innerHTML = "";
  const resultBlock = document.querySelector(".resultSecondTasckEratosphen");

  for (let i = 0; i < result.length; i += 6) {
    for (let j = 0; j < 6; j++) {
      if (j + i < result.length) {
        resultBlock.innerHTML += `<div id="resElement">${result[j + i]}</div>`;
      }
    }
    resultBlock.innerHTML += "</br>";
  }
  document.querySelector(".resultSecondTasckPherma").innerHTML = "";
  const resultBlockForThPherma = document.querySelector(
    ".resultSecondTasckPherma"
  );

  for (let i = 0; i < resultPherma.length; i += 6) {
    for (let j = 0; j < 6; j++) {
      if (j + i < result.length && resultPherma[j + i] !== undefined) {
        resultBlockForThPherma.innerHTML += `<div id="resElement">${
          resultPherma[j + i]
        }</div>`;
      }
    }
    resultBlockForThPherma.innerHTML += "</br>";
  }
};

const handlerFirstTask = () => {
  let borderValue = Math.pow(10, rang.value);
  const array = eratosphenMethod(2, borderValue);

  const result = getResultArray(array);
  resultForFirstTask.value = result[result.length - 1];
};

handleThirdTask = () => {
  const val = Number(numVal.value);

  const arrayEratosphen = eratosphenMethod(2, val + 100);
  const numericArrayEratosphen = getResultArray(arrayEratosphen);
  const arrayEratosphenISContainNumber = numericArrayEratosphen.includes(val);

  const arrayPherma = smallTheoremePherma(2, val + 100);
  const numericArrayPherma = getResultArray(arrayPherma);
  const arrayPhermaISContainNumber = numericArrayPherma.includes(val);

  if (arrayEratosphenISContainNumber) {
    earatosphen.value = "простое";
  }
  if (arrayPhermaISContainNumber && arrayEratosphenISContainNumber) {
    pherma_field.value = "простое";
  } else if (!arrayPhermaISContainNumber && arrayEratosphenISContainNumber) {
    pherma_field.value = "псевдопростое";
  } else {
    earatosphen.value = "составное";
    pherma_field.value = "псевдосоставное";
  }
};

document.querySelector("#rang").addEventListener("keyup", handlerFirstTask);
document
  .querySelector("#from")
  .addEventListener("keyup", handleChangeSecondTask);
document.querySelector("#a").addEventListener("keyup", handleChangeSecondTask);
document.querySelector("#to").addEventListener("keyup", handleChangeSecondTask);
document.querySelector("#numVal").addEventListener("keyup", handleThirdTask);
handleThirdTask();
handleChangeSecondTask();
handlerFirstTask();
