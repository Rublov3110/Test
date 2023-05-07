const SIZE = 9;
const SUB_SIZE = 3;

const isValid = (arr) => new Set(arr).size === SIZE && !arr.includes(0);

function validateSudokuBoard(board) {
  // check rows
  for (const row of board) {
    if (!isValid(row)) {
      return false;
    }
  }

  // check columns
  for (let i = 0; i < SIZE; i++) {
    const column = [];

    for (const row of board) {
      column.push(row[i]);
    }
    if (!isValid(column)) {
      return false;
    }
  }

  // check sub-grids
  for (let i = 0; i < SIZE; i += SUB_SIZE) {
    for (let j = 0; j < SIZE; j += SUB_SIZE) {
      const subgrid = [];

      for (let k = i; k < i + SUB_SIZE; k++) {
        for (let l = j; l < j + SUB_SIZE; l++) {
          subgrid.push(board[k][l]);
        }
      }

      if (!isValid(subgrid)) {
        return false;
      }
    }
  }

  return true;
}

const validBoard = [
  [5, 3, 4, 6, 7, 8, 9, 1, 2],
  [6, 7, 2, 1, 9, 5, 3, 4, 8],
  [1, 9, 8, 3, 4, 2, 5, 6, 7],
  [8, 5, 9, 7, 6, 1, 4, 2, 3],
  [4, 2, 6, 8, 5, 3, 7, 9, 1],
  [7, 1, 3, 9, 2, 4, 8, 5, 6],
  [9, 6, 1, 5, 3, 7, 2, 8, 4],
  [2, 8, 7, 4, 1, 9, 6, 3, 5],
  [3, 4, 5, 2, 8, 6, 1, 7, 9],
];

const invalidBoard = [
  [5, 3, 4, 6, 7, 8, 9, 1, 2],
  [6, 7, 2, 1, 9, 0, 3, 4, 8],
  [1, 0, 0, 3, 4, 2, 5, 6, 0],
  [8, 5, 9, 7, 6, 1, 0, 2, 0],
  [4, 2, 6, 8, 5, 3, 7, 9, 1],
  [7, 1, 3, 9, 2, 4, 8, 5, 6],
  [9, 0, 1, 5, 3, 7, 2, 1, 4],
  [2, 8, 7, 4, 1, 9, 6, 3, 5],
  [3, 0, 0, 4, 8, 1, 1, 7, 9],
];

console.log(validateSudokuBoard(validBoard));
console.log(validateSudokuBoard(invalidBoard));
