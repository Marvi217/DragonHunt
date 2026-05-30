# DragonHunt – Polowanie na Smoka

Aplikacja desktopowa napisana w **C# (.NET 8 / Windows Forms)** symulująca walkę drużyny bohaterów ze smokiem. Projekt powstał jako ćwiczenie z zaawansowanego programowania obiektowego w C#.

---

## Struktura rozwiązania

```
DragonHuntClaude.sln
├── Lib/                  # Biblioteka klas (DragonHuntLib)
│   ├── Character.cs      # Abstrakcyjna klasa bazowa postaci
│   ├── Warrior.cs        # Wojownik
│   ├── Archer.cs         # Łucznik
│   ├── Wizard.cs         # Czarodziej
│   └── Dragon.cs         # Smok + delegat FireBreathHandler
└── DragonHunt/           # Aplikacja desktopowa (Windows Forms)
    ├── Program.cs         # Punkt wejścia
    ├── Form1.cs           # Główna formatka – logika bitwy
    ├── CharacterPanel.cs  # Kontrolka UserControl dla bohatera
    ├── MonsterPanel.cs    # Kontrolka UserControl dla smoka
    └── CharacterExtensions.cs  # Metody rozszerzeniowe
```

---

## Jak uruchomić

**Wymagania:**
- .NET 8 SDK (lub nowszy)
- System Windows (Windows Forms)

```bash
# Zbuduj i uruchom
dotnet run --project DragonHunt/DragonHunt.csproj
```

Lub otwórz `DragonHuntClaude.sln` w Visual Studio i naciśnij `F5`.

---

## Zasady gry

1. Drużyna składa się z trzech bohaterów: **Thorin** (Wojownik), **Legolas** (Łucznik), **Gandalf** (Czarodziej).
2. Przeciwnikiem jest potężny smok **Smaug** (poziom 10, 300 HP).
3. Każda **runda walki**:
   - Wszyscy żyjący bohaterowie atakują smoka.
   - Jeśli smok przeżył – zieje ogniem, zadając obrażenia całej drużynie.
4. Drużyna może wypić do **3 mikstur leczenia** (przycisk przy każdym bohaterze).
5. Przed bitwą można dodać bohaterom **punkty doświadczenia** (pole XP + przycisk), aby ich awansować na wyższy poziom.
6. Przyciski **„Następna runda"** i **„Symuluj całą bitwę"** sterują przebiegiem.
7. Po zakończeniu bitwy aktywny jest przycisk **„Reset"**, który przywraca stan początkowy.

---

## Funkcje interfejsu

| Element UI | Działanie |
|---|---|
| Paski HP (ProgressBar) | Stan zdrowia każdej postaci w czasie rzeczywistym |
| Pasek XP | Postęp do następnego poziomu |
| Pasek MP (tylko Czarodziej) | Aktualna mana |
| Etykieta „Mikstury" | Liczba pozostałych mikstur (max 3) |
| Przycisk „Pij miksturę" | Pełne leczenie wybranego bohatera |
| Pole XP + „Dodaj XP" | Dodaj doświadczenie przed bitwą |
| „Następna runda" | Jedna runda walki krok po kroku |
| „Symuluj całą bitwę" | Automatyczna symulacja do końca |
| „Reset" | Powrót do stanu początkowego |
| Etykieta wyniku | „Drużyna zwyciężyła!" lub „Smok was pożarł!" |
