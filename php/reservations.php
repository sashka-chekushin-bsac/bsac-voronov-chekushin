<?php

include 'mailer.php';

$sendEmailTo        = 'your@email.com';
$emailFrom          = 'my Ресторан Уткинаname';
$requiredFields     = ['name', 'email', 'seats', 'date', 'time'];
$optionalFields     = ['phone', 'message'];

sendEmail($sendEmailTo, $emailFrom, $requiredFields, $optionalFields, 'We have a new reservation!');