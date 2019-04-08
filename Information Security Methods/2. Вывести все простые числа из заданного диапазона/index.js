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

const smallTheoremePherma = (a, valueTo) => {
  const arr = [];
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

const getResultArray = (array, from = 0, to = array.length) => {
  const resultArray = [];

console.log(to)

  for(let i = from; i <= to; i++) {
    if (array[i]) {
      resultArray.push(i);
    }
  }

  return resultArray;
};

const handleChangeSecondTask = event => {
  const valueFrom = a.value;
  const valueTo = to.value;

  const booleanArray = eratosphenMethod(valueTo);
  const result = getResultArray(booleanArray, valueFrom, valueTo);
  const thPherme = smallTheoremePherma(2, valueTo);
  const resultPherma = getResultArray(thPherme, valueFrom, valueTo);
  document.querySelector(".resultSecondTasckEratosphen").innerHTML = "";
  const resultBlock = document.querySelector(".resultSecondTasckEratosphen");

  for (let i = 0; i < result.length; i += 6) {
    for (let j = 0; j < 6; j++) {
      if (j + i < result.length) {
        resultBlock.innerHTML += `<div id="resElement">${result[j + i]}</div>`;
      }
    }
  }

  document.querySelector(".resultSecondTaskPherma").innerHTML = "";
  const resultBlockForThPherma = document.querySelector(
    ".resultSecondTaskPherma"
  );

  for (let i = 0; i < resultPherma.length; i += 6) {
    for (let j = 0; j < 6; j++) {
      if (j + i < result.length && resultPherma[j + i] !== undefined) {
        resultBlockForThPherma.innerHTML += `<div id="resElement">${
          resultPherma[j + i]
        }</div>`;
      }
    }
  }
};

document.querySelector("#a").addEventListener("change", handleChangeSecondTask);
document.querySelector("#to").addEventListener("change", handleChangeSecondTask);
handleChangeSecondTask();
