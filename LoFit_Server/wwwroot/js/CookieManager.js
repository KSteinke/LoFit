export function get()
{
    return document.cookie;
}

export function set(key, value, expirationDays) {
    let expirationDate = "";
    if (expirationDays) {
        const date = new Date();
        date.setTime(date.getTime() + (expirationDays * 24 * 60 * 60 * 1000));
        expirationDate = "; expires=" + date.toUTCString();
    }
    document.cookie = `${key}=${value}${expirationDate}; path=/`;
}

export function exists(key)
{
     // Pobranie wszystkich ciasteczek
     const cookies = document.cookie.split(';');

     // Przeszukanie ciasteczek w poszukiwaniu ciasteczka o określonej nazwie
     for (let i = 0; i < cookies.length; i++) {
         const cookie = cookies[i].trim();
         // Sprawdzenie, czy ciasteczko zaczyna się od określonej nazwy
         if (cookie.startsWith(`${key}=`)) {
             return true; // Znaleziono ciasteczko
         }
     }
 
     return false; // Nie znaleziono ciasteczka
}