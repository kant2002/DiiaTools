# Завантажити усі репозиторії
gh repo list diia-open-source --json "name,url" --limit 50  | ConvertFrom-Json | ForEach-Object {
	$name = $_.name
	$url = $_.url
	$exists = $(Test-Path -Path $name)
	Write-Host "Cloning $name"
	if (!$exists) {
		echo "Cloning from $url"
		git clone $url
	} else {
		echo "skipped"
	}
}
