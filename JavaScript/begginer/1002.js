var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const pi = 3.14159;
const r = parseFloat(lines[0]);
let area = pi * r ** 2;
area = area.toFixed(4);

console.log(`A=${area}`);