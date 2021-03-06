import System.IO

project_dir = "PhantomExample"
config_dir = project_dir + "/Configuration"
configuration = "release"

desc "Copying configuration files"
target copyconfiguration:
  with FileList(config_dir):
    .Include("*.config")
    .ForEach def(file):
      file_to_copy = "${config_dir}/${file.Name}"
      machine_specific_file = "${config_dir}/${System.Environment.MachineName}/${file.Name}"
      if File.Exists(machine_specific_file):
        file_to_copy = machine_specific_file
      print "Copying ${file_to_copy} to ${project_dir}/${file.Name}"  
      File.Copy(file_to_copy, "${project_dir}/${file.Name}", true)
