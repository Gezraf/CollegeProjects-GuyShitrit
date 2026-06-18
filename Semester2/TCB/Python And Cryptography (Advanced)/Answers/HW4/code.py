from random import randint

def otp_xor(text, key):
    if len(text) != len(key): # חייב שהאורכים של ההודעה והמפתח יהיו שווים
        raise Exception("Lengths of the text and key must be equal!")
    
    return ''.join(chr(ord(text_char) ^ ord(key_char)) for text_char, key_char in zip(text, key))

try:
    msg = "ABCDEFGH" # ההודעה המקורית
    key = ''.join(chr(randint(ord('A'), ord('Z'))) for c in msg) # מפתח אקראי לדוגמא
    cipher = otp_xor(msg, key)
    decrypted = otp_xor(cipher, key)
    
    print(f"Random key: {key}")
    print(f"Ciphertext:       {repr(cipher)}")
    print(f"Decrypted output: {decrypted}")
    
except Exception as e:
    print(e)
