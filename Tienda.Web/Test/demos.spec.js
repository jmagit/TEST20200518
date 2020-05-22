describe('Validaciones', function () {
    it('Es un NIF valido', function () {
        expect(isNIF('12345678Z')).toBe(true);
    });
    it('Es un NIF incorrecto', function () {
        expect(isNIF('1234A')).toBe(false);
    });
});