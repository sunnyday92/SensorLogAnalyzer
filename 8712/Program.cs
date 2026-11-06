Console.WriteLine("Sensor Log Analyzer v0.1");

var lines = File.ReadAllLines("data/sample.csv");
var readings = new List<SensorReading>(); // Создаем список для наших объектов

foreach (var line in lines)
{
    // Разбиваем строку по запятой на массив частей
    var parts = line.Split(',');

    // Если частей не 3, значит строка битая, пропускаем её
    if (parts.Length != 3) continue;

    // Создаем объект и заполняем его данными
    var reading = new SensorReading
    {
        Timestamp = DateTime.Parse(parts[0]),
        SensorName = parts[1],
        // Используем InvariantCulture, чтобы точка в числе 23.5 читалась правильно (а не как ошибка)
        Value = double.Parse(parts[2], System.Globalization.CultureInfo.InvariantCulture)
    };

    readings.Add(reading); // Добавляем в список
}

Console.WriteLine($"Распознано записей: {readings.Count}");