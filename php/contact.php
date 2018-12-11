<?php

include 'mailer.php';

$sendEmailTo        = 'your@email.com';
$emailFrom          = 'my Ресторан Уткинаname';
$requiredFields     = ['name', 'email', 'message'];
$optionalFields     = [];

sendEmail($sendEmailTo, $emailFrom, $requiredFields, $optionalFields, 'New email from contactform');