const redis = require('redis');
const client = redis.createClient();

let start, end;

start = Date.now();
for(let i = 0; i < 10000; i++) {
    client.set(`key${i}`, `value${i}`, redis.print);
}
end = Date.now();
console.log(`Время выполнения 10000 запросов set: ${end - start} мс`);

start = Date.now();
for(let i = 0; i < 10000; i++) {
    client.get(`key${i}`, redis.print);
}
end = Date.now();
console.log(`Время выполнения 10000 запросов get: ${end - start} мс`);

start = Date.now();
for(let i = 0; i < 10000; i++) {
    client.del(`key${i}`, redis.print);
}
end = Date.now();
console.log(`Время выполнения 10000 запросов del: ${end - start} мс`);

client.quit();
