$(document).ready(function () {

	//Get the location URL information
	var appRoot = "";
	var serviceUrl = 'http://localhost:8491';

	// Refresh the list of messages every 2 seconds
	setInterval(function () { GetMessages(); }, 2000);


	$('#sendButton').click(function () {
		AddMessage();
	});

	$('#regButton').click(function () {
		$("#lblName").text($("#inputName").val());
		$("#divName").hide(1000);
		$("#divNameHidden").show(1000);
		$("#gameBoard").show(1000);
	});

	$('#deleteButton').click(function () {
		DeleteMessages();
	});

	//Call the default POST message for
	function AddMessage() {
		var name = $('#lblName').text();
		var answer = $('#inputMessage').val();

		var message = { MessageText: answer, Name: name };

		$.ajax({
			url: serviceUrl + appRoot + '/api/chat/',
			type: 'POST',
			contentType: 'application/json',
			dataType: 'json',
			data: JSON.stringify(message)
		})
			.done(function (addMessage) {
				$('#inputMessage').val('');
			});
	}


	function DeleteMessages() {
		$.ajax({
			url: serviceUrl + appRoot + '/api/chat/',
			type: 'DELETE',
			contentType: 'application/json',
			dataType: 'json'
		})
			.done(function (result) {
				$('#messages').empty();
			});
	}

	function GetMessages() {
		$.ajax({
			url: serviceUrl + appRoot + '/api/chat/',
			type: 'GET',
			contentType: 'application/json',
			datatype: 'json',
			cache: false
		})
			.done(function (getMessageResult) {
				bindData($('#messages'), getMessageResult);
			});
	}

	//Take returned messages and construct list items
	function bindData(element, data) {

		$('#messages').empty();

		$.each(data, function (id, jobject) {
			$('<li/>')
				.append(
					$('<span class="message-time"/>').text(formatDateTime(jobject.Key)))
				.append(
					$('<span class="message-from"/>').text(jobject.Value.Name))
				.append(': ')
				.append(
					 $('<span class="message-body"/>').text(jobject.Value.MessageText))
				.appendTo(element);
		});
	}

	function formatDateTime(dateObject) {
		var d = new Date(dateObject);
		var sec = d.getSeconds();
		var min = d.getMinutes();
		var hour = d.getHours();
		var time = "(" + hour + ":" + min + ":" + sec +") ";

		return time;
	}

});