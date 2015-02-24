<?php
?>
<!DOCTYPE html>
<html>
	<head>
		<script type="text/javascript" src="lib/jquery-1.7.2.js"></script>
		<script type="text/javascript" src="lib/jquery-1.7.2.min.js"></script>
		<script type="text/javascript" src="client/web/login.js"></script>
		<script type="text/javascript" src="client/web/app.js"></script>
		<script type="text/javascript">
			
			function setAuthenticated(args){
				if(args == "False")
				window.user = null;
			}
			function login(){
				login = ""; passwd = "";				
				try{
					login = document.getElementById('login').value;
					passwd = document.getElementById('passw').value;
				}catch(e){
					// No HTML elements identified by 'login' and 'passw'
					return false;
				}
				return My.login(
							document.getElementById('login').value,
							document.getElementById('passw').value
							);
			}
		</script>
	</head>
	<body>
		<script>
			if(login()){
				My.App.run();
			}else{
				My.App.lock();
			}
		</script>
	</body>
</html>
<?php
?>