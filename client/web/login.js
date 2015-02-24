/******************************************************************************
 *
 *
 *
 *
 ******************************************************************************/


/// The global namespace 
var My = {};

/// The authenticator object
var authenticator = window.external.Ad;

My.login = function(username, password){
	if (window.user != null) return true; 
	return  window.authenticator.Authenticate(username, password);
}

