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
				$childPackages = $_ | Get-Member | Where-Object { $_.MemberType -eq "NoteProperty" } | Where-Object { $_.Name.Contains("service") } | Select-Object -ExpandProperty "Name"
				$childPackages | ForEach-Object {
					$pp = $name.Replace('@diia-inhouse/', '').Replace('@kant2002-diia-inhouse/', '').Replace('-client', '')
					$c = $_.Replace('@diia-inhouse/', '').Replace('@kant2002-diia-inhouse/', '').Replace('-client', '')
					"  $pp --> $c"
				}
			}
		}
		$pd = $json.peerDependencies
		if ($pd) {
			#$pd
			$pd | ForEach-Object { 
				$childPackages = $_ | Get-Member | Where-Object { $_.MemberType -eq "NoteProperty" } | Where-Object { $_.Name.Contains("service") } | Select-Object -ExpandProperty "Name"
				$childPackages | ForEach-Object {
					$pp = $name.Replace('@diia-inhouse/', '').Replace('@kant2002-diia-inhouse/', '').Replace('-client', '')
					$c = $_.Replace('@diia-inhouse/', '').Replace('@kant2002-diia-inhouse/', '').Replace('-client', '')
					"  $pp --> |peer| $c"
				}
			}
		}
		if ($name.Contains("service"))
		{
			"  " + $name.Replace('@diia-inhouse/', '').Replace('@kant2002-diia-inhouse/', '').Replace('-client', '')
		}
	}
}

