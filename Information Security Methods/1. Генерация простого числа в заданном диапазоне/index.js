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

const getResultArray = array => {
  const resultArray = [];

  array.forEach((item, index) => {
    if (item) {
      resultArray.push(index);
    }
  });

  return resultArray;
};

function randomInteger(min, max) {
  var rand = min + Math.random() * (max + 1 - min);
  rand = Math.floor(rand);
  return rand;
}

const handlerFirstTask = () => {
  let borderValue = Math.pow(10, rang.value);
  const array = eratosphenMethod(2, borderValue);

  const result = getResultArray(array);
  resultForFirstTask.value = result[randomInteger(0, result.length - 1)];
};

document.querySelector("#rang").addEventListener("change", handlerFirstTask);
handlerFirstTask();
