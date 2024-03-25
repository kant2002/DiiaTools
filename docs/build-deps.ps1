# Побудувати залежності для Русалки
ls | ForEach-Object {
	#ls $_.Name
	$parentPackage = $_.Name
	$repository = $_.repository
	$packageJsonPath = "${parentPackage}\package.json"
	#$packageJsonPath
	if (Test-Path -Path $packageJsonPath) {
		$json = Get-Content $packageJsonPath | ConvertFrom-Json
		$name = $json.name
		$repository = $json.repository
		$d = $json.dependencies
		if ($d) {
			#$d
			$d | ForEach-Object { 
				$childPackages = $_ | Get-Member | Where-Object { $_.MemberType -eq "NoteProperty" } | Where-Object { $_.Name.StartsWith("@diia") } | Select-Object -ExpandProperty "Name"
				$childPackages | ForEach-Object {
					$pp = $name.Replace('@diia-inhouse/', '')
					$c = $_.Replace('@diia-inhouse/', '')
					"  $pp --> $c"
				}
			}
		}
		$pd = $json.peerDependencies
		if ($pd) {
			#$d
			$pd | ForEach-Object { 
				$childPackages = $_ | Get-Member | Where-Object { $_.MemberType -eq "NoteProperty" } | Where-Object { $_.Name.StartsWith("@diia") } | Select-Object -ExpandProperty "Name"
				$childPackages | ForEach-Object {
					$pp = $name.Replace('@diia-inhouse/', '')
					$c = $_.Replace('@diia-inhouse/', '')
					"  $pp --> |peer| $c"
				}
			}
		}
		"click validators """ + $repository + """"
	}
}

