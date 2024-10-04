string[] popularPasswords = [
 "password", "qwerty", "password1", "admin", "letmein", "welcome", "monkey",
"dragon", "iloveyou", "sunshine", "football", "asdfgh", "zxcvbnm", "qwertyuiop", 
 "superman", "michael", "princess", "azerty", "trustno1", "charlie", "freedom",
"password123","flower", "passw0rd", "shadow"
];

string? mdp;
bool isPasswordSecure = false;

bool isPasswordLongerThan8(string mdp){
    if(mdp.Length > 8){
        return true;
    }
    else{
        return false;
    }
}

bool doesPasswordHaveNumber(string mdp){
    bool hasDigit = false;
    for(int i = 0; i < mdp.Length; i++){
        hasDigit = Char.IsDigit(mdp, i);
        if(hasDigit == true){
            return true;
        }
    }
    return false;
}

bool isPasswordPopular(string mdp){
    for(int i = 0; i < popularPasswords.Length; i++){
        if(mdp == popularPasswords[i]){
            return true;
        }
    }
    return false;
}

while(isPasswordSecure != true){
    Console.WriteLine("Écrivez votre mot de passe:");
    mdp = Console.ReadLine();

    if(isPasswordPopular(mdp) == false){
        if(doesPasswordHaveNumber(mdp) == true){
            if(isPasswordLongerThan8(mdp) == true){
                Console.WriteLine("Bravo, votre mot de passe est sécuritaire.");
                isPasswordSecure = true;
            }
            else{
                Console.WriteLine("Votre mot de passe n'est pas sécuritaire, car il contient moins de 8 caractères. Réessayer.");
                Thread.Sleep(1500);
            }
        }
        else{
        Console.WriteLine("Votre mot de passe n'est pas sécuritaire, car il ne contient aucun nombre. Réessayer.");
        Thread.Sleep(1500);
        }
    }
    else{
        Console.WriteLine("Votre mot de passe n'est pas sécuritaire, car il est trop populaire. Réessayer.");
        Thread.Sleep(1500);
    }
}