//DELETE TARGET FOLDER
//Admin Password
//Initialize Plugins
//Setup Maven and Docker

//Limited form of Groovy Syntax.

//SCRIPTED PIPELINES
//Node - a machine to run the pipelines
//Stage blocks are optional in scripted pipelines
//node {
// 	stage('Build') {
// 		echo "Build"
// 	}
// 	stage('Test') {
// 		echo "Test"
//	}
// }
pipeline {
	agent any
	stages {
		stage('Build'){
			steps {
				echo "Build"
			}
		}
	}
	stages {
		stage('Test'){
			steps {
				echo "Test"
			}
		}
	}
	stages {
		stage('Integration Test'){
			steps {
				echo "Integration Test"
			}
		}
	}

}

