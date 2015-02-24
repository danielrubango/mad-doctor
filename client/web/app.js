/*******************************************************************
 *
 *
 *
 *******************************************************************/
 
 
if (typeof My === 'undefined') My = {};


Application = function(){}

Application.prototype.run = function(){
}

Application.prototype.lock = function(){
	var html = '\
	<div id="login-box">\
		<h2 class="box-caption">Please log in</h2>\
		</br>\
		<input type="text" value="User" name="login" id="login"/>\
		</br>\
		<input type="password" name="password" id="password"/>\
		</br>\
		<span class="buttons" id="submit-credentials">Log in</span>\
	</div>\
	'
	$("body").html(html);
	
	$('#submit-credentials').click(function(){
		if(My.login(document.getElementById('login').value,
					document.getElementById('password').value))
					$("body").html("Logged in successfully");
		else $("body").html("Invalid user");
	});
}


My.App = new Application();


