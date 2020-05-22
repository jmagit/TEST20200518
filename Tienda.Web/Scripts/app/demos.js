function isNIF(valor) {
    if (!(/^\d{1,8}\w$/.test(valor))) return false;
    var letterValue = valor.substr(valor.length - 1);
    var numberValue = valor.substr(0, valor.length - 1);
    return letterValue.toUpperCase() === 'TRWAGMYFPDXBNJZSQVHLCKE'.charAt(numberValue % 23);
} 