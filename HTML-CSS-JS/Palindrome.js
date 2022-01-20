function palindrome(str){
    var reg = /[\W_]/g;
    var smallStr = str.toLowerCase().replace(reg,'');

    var reverse = smallStr.split('').reverse().join('');
    if (reverse === smallStr)return smallStr + " is a Palindrome";

    return "Not";
}
console.log(palindrome('malayalam'));
