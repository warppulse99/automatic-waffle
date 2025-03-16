import Foundation

func celsiusToFahrenheit(_ celsius: Double) -> Double {
    return (celsius * 9/5) + 32
}

func fahrenheitToCelsius(_ fahrenheit: Double) -> Double {
    return (fahrenheit - 32) * 5/9
}

print("🌡 Enter temperature: ")
if let input = readLine(), let temp = Double(input) {
    print("Convert to (C)elsius or (F)ahrenheit? (C/F):")
    if let choice = readLine(), choice.uppercased() == "F" {
        print("\(temp)°C = \(celsiusToFahrenheit(temp))°F")
    } else {
        print("\(temp)°F = \(fahrenheitToCelsius(temp))°C")
    }
} else {
    print("❌ Invalid input!")
}
