const redis = require('redis');

    const client = redis.createClient();

    client.on('connect', function() {
        console.log('Успешное соединение с сервером Redis!');
    });

    client.on('error', function(err) {
        console.log('Не удалось подключиться к серверу Redis:', err);
    });
    
    client.connect();


