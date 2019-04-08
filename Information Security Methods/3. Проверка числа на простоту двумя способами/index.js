const getRandom = (min, max) => {
  let rand = min - 0.5 + Math.random() * (max - min + 1);
  rand = Math.round(rand);
  return rand;
};

const eratosphenMethod = (valueTo) => {
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

const smallTheoremePherma = (valueTo) => {
  const arr = [];

let a = 2;

  for (let i = 0; i <= valueTo; i++) {
    arr[i] = true;
  }

  arr[0] = false;
  arr[1] = false;

  for (let i = 3; i <= valueTo; i++) {
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

handleThirdTask = () => {
  const val = Number(numVal.value);

  const arrayEratosphen = eratosphenMethod(val + 100);
  const numericArrayEratosphen = getResultArray(arrayEratosphen);
  const arrayEratosphenIsContainNumber = numericArrayEratosphen.includes(val);

  const arrayPherma = smallTheoremePherma(val + 100);
  const numericArrayPherma = getResultArray(arrayPherma);
  const arrayPhermaISContainNumber = numericArrayPherma.includes(val);

  if (arrayEratosphenIsContainNumber) {
    earatosphen.innerHTML = "простое";
  }
  if (arrayPhermaISContainNumber && arrayEratosphenIsContainNumber) {
    pherma_field.innerHTML = "простое";
  } else if (!arrayPhermaISContainNumber && arrayEratosphenIsContainNumber) {
    pherma_field.innerHTML = "псевдопростое";
  } else {
    earatosphen.innerHTML = "составное";
    pherma_field.innerHTML = "псевдосоставное";
  }
};

document.querySelector("#numVal").addEventListener("change", handleThirdTask);
handleThirdTask();
