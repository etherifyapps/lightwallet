var Etherify = {
    //Btc: {},
    Eth: {}
};

//module.exports = Etherify;

_hookekEthereumHost: "http://hookedethereum:8545";
Etherify.Eth.setHookekEthereumHost = function (value) {
    //TODO: Validate url
    _hookekEthereumHost = value;
}
Etherify.Eth.getHookekEthereumHost = function () {
    return _hookekEthereumHost;
}


function CallbackDotNet(method, obj) {
    try {
        Native(method, obj);
    } catch (e) {
        debug(e);
    }
}


Etherify.Eth.createRandom12Words = function (userRandomString /*optional*/ ) {

    if (typeof userRandomString === 'undefined') {
        //TODO: Maybe we could get some additional "random" information from the system to help in this case
        userRandomString = '';
    }

    var random12Words = lightwallet.keystore.generateRandomSeed(userRandomString);

    var result = {
        success: true,
        random12Words: random12Words,
        error: '',
    };

    CallbackDotNet('createRandom12WordsResult', result);

    return result;
}


Etherify.Eth.createEncryptedWallet = function (password, random12Words) {
    //TODO: Validate password
    //TODO: Validate random12Words

    //lightwallet.keystore.deriveKeyFromPassword(password, function (err, pwDerivedKey) {
    //global_keystore = new lightwallet.keystore(random12Words, pwDerivedKey);

    //newAddresses(password);
    //setWeb3Provider(global_keystore);
    //getBalances();
    //});
}



//////////////////////////////////////////
/*
function hello() {
    window.alert('Hello Xamarin (from etherifyLib.js file at iOS)!');
}

function generateNewAddress() {
    window.alert('iniciando generateNewAddress()');

    // generate a new BIP32 12-word seed
    var secretSeed = lightwallet.keystore.generateRandomSeed();

    // the seed is stored encrypted by a user-defined password
    var password = prompt('Enter password for encryption', 'password');
    lightwallet.keystore.deriveKeyFromPassword(password, function (err, pwDerivedKey) {

        var ks = new lightwallet.keystore(secretSeed, pwDerivedKey);

        // generate five new address/private key pairs
        // the corresponding private keys are also encrypted
        ks.generateNewAddress(pwDerivedKey, 5);
        var addr = ks.getAddresses();

        window.alert(addr);


        // Create a custom passwordProvider to prompt the user to enter their
        // password whenever the hooked web3 provider issues a sendTransaction
        // call.
        ks.passwordProvider = function (callback) {
            var pw = prompt("Please enter password", "Password");
            callback(null, pw);
        };

        // Now set ks as transaction_signer in the hooked web3 provider
        // and you can start using web3 using the keys/addresses in ks!
    });
}
*/