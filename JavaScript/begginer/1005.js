var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const a = parseFloat(lines[0]);
const b = parseFloat(lines[1]);
let c = (a * 3.5 + b * 7.5) / (3.5 + 7.5);
c = c.toFixed(5);

console.log(`MEDIA = ${c}`);
